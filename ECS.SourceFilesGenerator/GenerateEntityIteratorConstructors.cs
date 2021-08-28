using System.Linq;
using System.Text;
using Scriban;

namespace ECS.SourceFilesGenerator
{
    public static class GenerateEntityIteratorConstructors
    {
        public static string GenerateConstructors(int maxParametersCount)
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= maxParametersCount; i++)
            {
                sb.AppendLine(GenerateConstructor(i));
                sb.AppendLine();
            }

            return sb.ToString();
        }
        
        public static string GenerateConstructor(int parametersCount)
        {
            var indexes = Enumerable.Range(1, parametersCount).ToArray();
            var parameters = string.Join(", ", indexes.Select(i => $"T{i}"));
            var template = Template.Parse(@"
            public EntityIterator<{{ parameters }}> FindEntities<{{ parameters }}>()
                {{~ for index in indexes ~}}
                where T{{ index }} : struct
                {{~ end ~}}
            {
                return new EntityIterator<{{ parameters }}>(
                    Component.GetTags<{{ parameters }}>(),
                    _entitiesCount,
                    _entities
                    {{~ for index in indexes ~}}
                    , (T{{ index }}[])_components[Component<T{{ index }}>.Index]
                    {{~ end ~}});
            }");

            return template.Render(new { indexes, parameters });
        }
    }
}