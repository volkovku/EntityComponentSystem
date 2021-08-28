using System;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;

namespace ECS.Test
{
    [TestFixture]
    public class EntityManagerTest
    {
        private struct Component1
        {
            public int Value;
        }

        private struct Component2
        {
        }

        private struct Component3
        {
            public int Value;
        }

        [Test]
        public void EntityManager_ShouldCreateNewEntity()
        {
            var manager = new EntityManager(100, new LinealGrowStrategy(100));

            ref var entity = ref manager.New();
            entity = ref manager.New();

            Assert.AreEqual(1, entity.Index);
            Assert.AreEqual(0L, entity.Components);
        }

        [Test]
        public void EntityManager_ShouldSetComponent()
        {
            var manager = new EntityManager(100, new LinealGrowStrategy(100));

            ref var entity = ref manager.New();

            ref var c1 = ref manager.GetOrAdd<Component1>(ref entity, out _);
            c1.Value = 1;

            ref var c3 = ref manager.GetOrAdd<Component3>(ref entity, out _);
            c3.Value = 3;

            Assert.AreEqual(Component.GetTags<Component1, Component3>(), entity.Components);
        }

        [Test]
        public void EntityManager_ShouldRemoveComponent()
        {
            var manager = new EntityManager(100, new LinealGrowStrategy(100));
            ref var entity = ref manager.New();

            ref var c1 = ref manager.GetOrAdd<Component1>(ref entity, out _);
            c1.Value = 1;

            Component1 removedComponent = default;
            var isRemoved = manager.RemoveComponent(ref entity, ref removedComponent);
            Assert.IsTrue(isRemoved);
            Assert.AreEqual(1, removedComponent.Value);
            Assert.AreEqual(0L, entity.Components);
        }

        [Test]
        public void EntityManager_ShouldFindEntityWithComponents()
        {
            var manager = new EntityManager(100, new LinealGrowStrategy(100));
            for (var i = 0; i < 100; i++)
            {
                ref var entity = ref manager.New();
                if (i % 2 == 0)
                {
                    ref var component = ref manager.GetOrAdd<Component1>(ref entity, out _);
                    component.Value = i;
                }
            }

            var found = 0;
            Entity foundEntity = default;
            var iterator = manager.FindEntities<Component1>();
            while (iterator.MoveNext(ref foundEntity))
            {
                ref Component1 foundComponent = ref iterator.GetComponent1();
                Assert.AreEqual(0, foundEntity.Index % 2);
                Assert.AreEqual(found * 2, foundComponent.Value);
                found += 1;
            }

            Assert.AreEqual(50, found);
        }

        [Test]
        public void EntityManager_FoundEntitiesShouldBeMutable()
        {
            var manager = new EntityManager(100, new LinealGrowStrategy(100));
            for (var i = 0; i < 100; i++)
            {
                ref var entity = ref manager.New();
                if (i % 2 == 0)
                {
                    ref var component = ref manager.GetOrAdd<Component1>(ref entity, out _);
                    component.Value = i;
                }
            }

            Entity foundEntity = default;
            var iterator = manager.FindEntities<Component1>();
            while (iterator.MoveNext(ref foundEntity))
            {
                ref var component = ref iterator.GetComponent1();
                component.Value += 1;
            }

            var found = 0;
            var iterator2 = manager.FindEntities<Component1>();
            while (iterator2.MoveNext(ref foundEntity))
            {
                ref var component = ref iterator2.GetComponent1();
                Assert.AreEqual(0, foundEntity.Index % 2);
                Assert.AreEqual(found * 2 + 1, component.Value);
                found += 1;
            }
        }

        [Test]
        public void EntityManager_IterateManyEntities()
        {
            var capacity = 1_000_000;
            var manager = new EntityManager(1_000, DoubleGrowStrategy.Instance);

            var fill = Stopwatch.StartNew();
            for (var i = 0; i < capacity; i++)
            {
                ref var entity = ref manager.New();
                if (i % 5 == 0)
                {
                    ref var component = ref manager.GetOrAdd<Component1>(ref entity, out _);
                    component.Value = i;
                }

                if (i % 15 == 0)
                {
                    ref var component = ref manager.GetOrAdd<Component3>(ref entity, out _);
                    component.Value = i;
                }
            }

            fill.Stop();
            Console.WriteLine(fill.Elapsed);

            var sw = Stopwatch.StartNew();
            var found = 0;
            var iter = manager.FindEntities<Component1, Component3>();

            Entity foundEntity = default;
            while (iter.MoveNext(ref foundEntity))
            {
                found += 1;
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(found);
        }

        [Test]
        public void Gen()
        {
            var code = new StringBuilder();
            for (var i = 1; i <= 20; i++)
            {
                code.Append("public static long GetTags<");

                for (var t = 1; t <= i; t++)
                {
                    if (t != 1)
                    {
                        code.Append(", ");
                    }

                    code.Append($"T{t}");
                }

                code.AppendLine(">()");

                for (var t = 1; t <= i; t++)
                {
                    code.AppendLine($"where T{t} : IComponent");
                }

                code.AppendLine("{");
                code.AppendLine("return ");

                for (var t = 1; t <= i; t++)
                {
                    if (t != 1)
                    {
                        code.Append(" | ");
                    }

                    code.Append($"ComponentTag<T{t}>.Tag");
                }

                code.AppendLine(";");
                code.AppendLine("}");
            }

            Console.WriteLine(code);
        }
    }
}