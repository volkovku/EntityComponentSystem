using System;

namespace ECS
{
    public interface IComponentsArrayExtender
    {
        Array Extend(object old, int newSize);
    }

    public class TypedComponentsArrayExtender<TComponent> : IComponentsArrayExtender
        where TComponent : struct
    {
        public Array Extend(object source, int newSize)
        {
            var components = (TComponent[])source;
            var newComponents = new TComponent[newSize];
            Array.Copy(components, newComponents, components.Length);
            return newComponents;
        }
    }
}