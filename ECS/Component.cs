using System;
using System.Threading;

namespace ECS
{
    public static class Component<T> where T : struct
    {
        static Component()
        {
            var tag = Component.GetNextTag();
            Tag = tag.Value;
            Index = tag.Index;
            Component.SetArrayExtender<T>(new TypedComponentsArrayExtender<T>());
        }

        public static readonly long Tag;
        public static readonly int Index;
    }

    public static partial class Component
    {
        public const int MaxComponentsInSystem = 64;

        private static readonly IComponentsArrayExtender[] ComponentsArrayExtenders
            = new IComponentsArrayExtender[MaxComponentsInSystem];

        private static int _lastTagIndex = -1;

        public struct Tag
        {
            public Tag(int index, long value)
            {
                Index = index;
                Value = value;
            }

            public readonly int Index;
            public readonly long Value;
        }

        internal static Array ExtendArray(int componentIndex, object array, int newSize)
        {
            if (array == null)
            {
                return null;
            }

            IComponentsArrayExtender extender;
            lock (ComponentsArrayExtenders)
            {
                extender = ComponentsArrayExtenders[componentIndex];
            }

            return extender.Extend(array, newSize);
        }

        internal static void SetArrayExtender<T>(IComponentsArrayExtender extender) where T : struct
        {
            var index = Component<T>.Index;
            lock (ComponentsArrayExtenders)
            {
                ComponentsArrayExtenders[index] = extender;
            }
        }

        public static Tag GetNextTag()
        {
            var next = Interlocked.Increment(ref _lastTagIndex);
            var tag = 1L << next;
            return new Tag(next, tag);
        }
    }
}