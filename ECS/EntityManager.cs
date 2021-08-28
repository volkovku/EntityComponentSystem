using System;
using System.Collections.Generic;

namespace ECS
{
    /// <summary>
    /// Provides a set of methods to manage entities.
    /// </summary>
    public sealed partial class EntityManager
    {
        private readonly IGrowStrategy _growStrategy;
        private readonly Dictionary<int, int> _entitiesById = new Dictionary<int, int>();
        private readonly object[] _components;
        private Entity[] _entities;
        private int _lastId;
        private int _entitiesCount;

        /// <summary>
        /// Initializes a new instance of EntityManager class.
        /// </summary>
        /// <param name="initialCapacity">An initial capacity of entities.</param>
        /// <param name="growStrategy">A strategy of how internal arrays will grows when current capacity will exhausted.</param>
        public EntityManager(int initialCapacity, IGrowStrategy growStrategy)
        {
            _growStrategy = growStrategy;
            _entities = new Entity[initialCapacity];
            _components = new object[Component.MaxComponentsInSystem];
        }

        /// <summary>
        /// Creates new entity.
        /// </summary>
        /// <returns>A ref to created entity.</returns>
        public ref Entity New()
        {
            ExtendInternalArraysIfRequired();

            var index = _entitiesCount;
            var id = _lastId;
            ref var entity = ref _entities[index];

            entity.Id = id;
            entity.Index = index;
            entity.Components = 0L;

            _entitiesCount += 1;
            _lastId += 1;
            _entitiesById[id] = index;

            return ref entity;
        }

        /// <summary>
        /// Gets or adds component to specified entity.
        /// If new component was added you should initialize or cleanup it manually.
        /// </summary>
        /// <param name="entity">An entity to add component.</param>
        /// <param name="isNew">True if new component was added, otherwise false.</param>
        /// <typeparam name="TComponent">A type of component to add.</typeparam>
        /// <returns>Returns a ref to component.</returns>
        public ref TComponent GetOrAdd<TComponent>(ref Entity entity, out bool isNew) where TComponent : struct
        {
            ref var foundEntity = ref FindEntity(ref entity, out var entityIndex);
            var componentIndex = Component<TComponent>.Index;
            var componentTag = Component<TComponent>.Tag;

            var components = (TComponent[])_components[componentIndex];
            if (components == null)
            {
                components = new TComponent[_entities.Length];
                _components[componentIndex] = components;
            }

            entity = foundEntity;
            isNew = (foundEntity.Components & componentTag) == 0;
            if (isNew)
            {
                foundEntity.Components |= componentTag;
            }

            return ref components[entityIndex];
        }

        public ref TComponent GetComponent<TComponent>(ref Entity entity) where TComponent : struct
        {
            FindEntity(ref entity, out var index);
            var componentIndex = Component<TComponent>.Index;

            var components = _components[componentIndex] as TComponent[];
            if (components == null)
            {
                components = new TComponent[_entities.Length];
                _components[componentIndex] = components;
            }

            return ref components[index];
        }

        public bool RemoveComponent<TComponent>(ref Entity entity) where TComponent : struct
        {
            TComponent component = default;
            return RemoveComponent(ref entity, ref component);
        }

        public bool RemoveComponent<TComponent>(ref Entity entity, ref TComponent component)
            where TComponent : struct
        {
            ref var foundEntity = ref FindEntity(ref entity, out var entityIndex);
            var componentIndex = Component<TComponent>.Index;
            var componentTag = Component<TComponent>.Tag;
            if ((foundEntity.Components & componentTag) != componentTag)
            {
                return false;
            }

            var components = _components[componentIndex] as TComponent[];
            if (components == null)
            {
                return false;
            }

            component = components[entityIndex];
            components[entityIndex] = default;
            foundEntity.Components &= ~componentTag;

            return true;
        }

        private ref Entity FindEntity(ref Entity target, out int index)
        {
            index = target.Index;
            ref var entity = ref _entities[index];
            if (entity.Index == target.Index)
            {
                return ref entity;
            }

            index = _entitiesById[target.Id];
            return ref _entities[index];
        }

        private void ExtendInternalArraysIfRequired()
        {
            if (_entitiesCount < _entities.Length)
            {
                return;
            }

            var newSize = _growStrategy.NewSize(_entitiesCount);
            var newEntities = new Entity[newSize];
            Array.Copy(_entities, newEntities, _entitiesCount);
            _entities = newEntities;

            var componentsByTypes = _components;
            for (var typeIndex = 0; typeIndex < componentsByTypes.Length; typeIndex++)
            {
                var components = componentsByTypes[typeIndex];
                componentsByTypes[typeIndex] = Component.ExtendArray(typeIndex, components, newSize);
            }
        }
    }
}