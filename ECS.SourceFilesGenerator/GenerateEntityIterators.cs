using System.Linq;
using System.Text;
using Scriban;

namespace ECS.SourceFilesGenerator
{
    public static class GenerateEntityIterators
    {
        public static string GenerateIterators(int maxParametersCount)
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= maxParametersCount; i++)
            {
                sb.AppendLine(GenerateIterator(i));
                sb.AppendLine();
            }

            return sb.ToString();
        }
        
        public static string GenerateIterator(int parametersCount)
        {
            var indexes = Enumerable.Range(1, parametersCount).ToArray();
            var parameters = string.Join(", ", indexes.Select(i => $"T{i}"));
            
            var template = Template.Parse(@"
public struct EntityIterator<{{ parameters }}>
    {{~ for index in indexes ~}}
    where T{{ index }} : struct
    {{~ end ~}}
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        {{~ for index in indexes ~}}
        private readonly T{{ index }}[] _components{{ index }};
        {{~ end ~}}
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            {{~ for index in indexes ~}}
            , T{{ index }}[] components{{ index }}
            {{~ end ~}}
        ) {
            _tag = tag;
            _entities = entities;
            {{~ for index in indexes ~}}
            _components{{ index }} = components{{ index }};
            {{~ end ~}}
            _entitiesCount = entitiesCount;
            _position = -1;
        }

        public bool MoveNext(ref Entity entity)
        {
            var index = _position + 1;
            while (true)
            {
                if (index >= _entitiesCount)
                {
                    _position = index;
                    return false;
                }

                entity = _entities[index];
                if ((entity.Components & _tag) != _tag)
                {
                    index += 1;
                    continue;
                }

                _position = index;
                return true;
            }
        }

        {{~ for index in indexes ~}}
        public ref T{{ index }} GetComponent{{ index }}()
        {
            return ref _components{{ index }}[_position];
        }
        {{~ end ~}}
    }");

            return template.Render(model: new { indexes, parameters });
        }
    }
}