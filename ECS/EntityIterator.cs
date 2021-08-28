namespace ECS
{
    public struct EntityIterator<T1>
        where T1 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }
    }


    public struct EntityIterator<T1, T2>
        where T1 : struct
        where T2 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2)
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3>
        where T1 : struct
        where T2 : struct
        where T3 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
        where T15 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly T15[] _components15;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
            , T15[] components15
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
            _components15 = components15;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }

        public ref T15 GetComponent15()
        {
            return ref _components15[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
        where T15 : struct
        where T16 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly T15[] _components15;
        private readonly T16[] _components16;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
            , T15[] components15
            , T16[] components16
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
            _components15 = components15;
            _components16 = components16;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }

        public ref T15 GetComponent15()
        {
            return ref _components15[_position];
        }

        public ref T16 GetComponent16()
        {
            return ref _components16[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
        where T15 : struct
        where T16 : struct
        where T17 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly T15[] _components15;
        private readonly T16[] _components16;
        private readonly T17[] _components17;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
            , T15[] components15
            , T16[] components16
            , T17[] components17
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
            _components15 = components15;
            _components16 = components16;
            _components17 = components17;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }

        public ref T15 GetComponent15()
        {
            return ref _components15[_position];
        }

        public ref T16 GetComponent16()
        {
            return ref _components16[_position];
        }

        public ref T17 GetComponent17()
        {
            return ref _components17[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
        where T15 : struct
        where T16 : struct
        where T17 : struct
        where T18 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly T15[] _components15;
        private readonly T16[] _components16;
        private readonly T17[] _components17;
        private readonly T18[] _components18;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
            , T15[] components15
            , T16[] components16
            , T17[] components17
            , T18[] components18
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
            _components15 = components15;
            _components16 = components16;
            _components17 = components17;
            _components18 = components18;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }

        public ref T15 GetComponent15()
        {
            return ref _components15[_position];
        }

        public ref T16 GetComponent16()
        {
            return ref _components16[_position];
        }

        public ref T17 GetComponent17()
        {
            return ref _components17[_position];
        }

        public ref T18 GetComponent18()
        {
            return ref _components18[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
        where T15 : struct
        where T16 : struct
        where T17 : struct
        where T18 : struct
        where T19 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly T15[] _components15;
        private readonly T16[] _components16;
        private readonly T17[] _components17;
        private readonly T18[] _components18;
        private readonly T19[] _components19;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
            , T15[] components15
            , T16[] components16
            , T17[] components17
            , T18[] components18
            , T19[] components19
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
            _components15 = components15;
            _components16 = components16;
            _components17 = components17;
            _components18 = components18;
            _components19 = components19;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }

        public ref T15 GetComponent15()
        {
            return ref _components15[_position];
        }

        public ref T16 GetComponent16()
        {
            return ref _components16[_position];
        }

        public ref T17 GetComponent17()
        {
            return ref _components17[_position];
        }

        public ref T18 GetComponent18()
        {
            return ref _components18[_position];
        }

        public ref T19 GetComponent19()
        {
            return ref _components19[_position];
        }
    }


    public struct EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20>
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
        where T9 : struct
        where T10 : struct
        where T11 : struct
        where T12 : struct
        where T13 : struct
        where T14 : struct
        where T15 : struct
        where T16 : struct
        where T17 : struct
        where T18 : struct
        where T19 : struct
        where T20 : struct
    {
        private readonly long _tag;
        private readonly Entity[] _entities;
        private readonly T1[] _components1;
        private readonly T2[] _components2;
        private readonly T3[] _components3;
        private readonly T4[] _components4;
        private readonly T5[] _components5;
        private readonly T6[] _components6;
        private readonly T7[] _components7;
        private readonly T8[] _components8;
        private readonly T9[] _components9;
        private readonly T10[] _components10;
        private readonly T11[] _components11;
        private readonly T12[] _components12;
        private readonly T13[] _components13;
        private readonly T14[] _components14;
        private readonly T15[] _components15;
        private readonly T16[] _components16;
        private readonly T17[] _components17;
        private readonly T18[] _components18;
        private readonly T19[] _components19;
        private readonly T20[] _components20;
        private readonly int _entitiesCount;
        private int _position;

        public EntityIterator(
            long tag,
            int entitiesCount,
            Entity[] entities
            , T1[] components1
            , T2[] components2
            , T3[] components3
            , T4[] components4
            , T5[] components5
            , T6[] components6
            , T7[] components7
            , T8[] components8
            , T9[] components9
            , T10[] components10
            , T11[] components11
            , T12[] components12
            , T13[] components13
            , T14[] components14
            , T15[] components15
            , T16[] components16
            , T17[] components17
            , T18[] components18
            , T19[] components19
            , T20[] components20
        )
        {
            _tag = tag;
            _entities = entities;
            _components1 = components1;
            _components2 = components2;
            _components3 = components3;
            _components4 = components4;
            _components5 = components5;
            _components6 = components6;
            _components7 = components7;
            _components8 = components8;
            _components9 = components9;
            _components10 = components10;
            _components11 = components11;
            _components12 = components12;
            _components13 = components13;
            _components14 = components14;
            _components15 = components15;
            _components16 = components16;
            _components17 = components17;
            _components18 = components18;
            _components19 = components19;
            _components20 = components20;
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

        public ref T1 GetComponent1()
        {
            return ref _components1[_position];
        }

        public ref T2 GetComponent2()
        {
            return ref _components2[_position];
        }

        public ref T3 GetComponent3()
        {
            return ref _components3[_position];
        }

        public ref T4 GetComponent4()
        {
            return ref _components4[_position];
        }

        public ref T5 GetComponent5()
        {
            return ref _components5[_position];
        }

        public ref T6 GetComponent6()
        {
            return ref _components6[_position];
        }

        public ref T7 GetComponent7()
        {
            return ref _components7[_position];
        }

        public ref T8 GetComponent8()
        {
            return ref _components8[_position];
        }

        public ref T9 GetComponent9()
        {
            return ref _components9[_position];
        }

        public ref T10 GetComponent10()
        {
            return ref _components10[_position];
        }

        public ref T11 GetComponent11()
        {
            return ref _components11[_position];
        }

        public ref T12 GetComponent12()
        {
            return ref _components12[_position];
        }

        public ref T13 GetComponent13()
        {
            return ref _components13[_position];
        }

        public ref T14 GetComponent14()
        {
            return ref _components14[_position];
        }

        public ref T15 GetComponent15()
        {
            return ref _components15[_position];
        }

        public ref T16 GetComponent16()
        {
            return ref _components16[_position];
        }

        public ref T17 GetComponent17()
        {
            return ref _components17[_position];
        }

        public ref T18 GetComponent18()
        {
            return ref _components18[_position];
        }

        public ref T19 GetComponent19()
        {
            return ref _components19[_position];
        }

        public ref T20 GetComponent20()
        {
            return ref _components20[_position];
        }
    }
}