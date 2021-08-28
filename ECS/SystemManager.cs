using System.Collections.Generic;

namespace ECS
{
    public sealed class SystemManager
    {
        private readonly List<ISystem> _systems = new List<ISystem>();
        private readonly EntityManager _entityManager;

        public SystemManager(EntityManager entityManager)
        {
            _entityManager = entityManager;
        }

        public void AddSystem(ISystem system)
        {
            _systems.Add(system);
        }

        public void Init()
        {
            var entityManager = _entityManager;
            foreach (var system in _systems)
            {
                system.Init(entityManager);
            }
        }

        public void Update()
        {
            var entityManager = _entityManager;
            foreach (var system in _systems)
            {
                system.Update(entityManager);
            }
        }
    }
}