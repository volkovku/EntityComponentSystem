namespace ECS
{
    public sealed partial class EntityManager
    {
        public EntityIterator<T1> FindEntities<T1>()
            where T1 : struct
        {
            return new EntityIterator<T1>(
                Component.GetTags<T1>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
            );
        }


        public EntityIterator<T1, T2> FindEntities<T1, T2>()
            where T1 : struct
            where T2 : struct
        {
            return new EntityIterator<T1, T2>(
                Component.GetTags<T1, T2>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
            );
        }


        public EntityIterator<T1, T2, T3> FindEntities<T1, T2, T3>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
        {
            return new EntityIterator<T1, T2, T3>(
                Component.GetTags<T1, T2, T3>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4> FindEntities<T1, T2, T3, T4>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
        {
            return new EntityIterator<T1, T2, T3, T4>(
                Component.GetTags<T1, T2, T3, T4>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5> FindEntities<T1, T2, T3, T4, T5>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new EntityIterator<T1, T2, T3, T4, T5>(
                Component.GetTags<T1, T2, T3, T4, T5>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6> FindEntities<T1, T2, T3, T4, T5, T6>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new EntityIterator<T1, T2, T3, T4, T5, T6>(
                Component.GetTags<T1, T2, T3, T4, T5, T6>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7> FindEntities<T1, T2, T3, T4, T5, T6, T7>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
            where T7 : struct
        {
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8> FindEntities<T1, T2, T3, T4, T5, T6, T7, T8>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
            where T7 : struct
            where T8 : struct
        {
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9> FindEntities<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> FindEntities<T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> FindEntities<T1, T2, T3, T4, T5, T6, T7, T8,
            T9, T10, T11>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> FindEntities<T1, T2, T3, T4, T5, T6,
            T7, T8, T9, T10, T11, T12>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> FindEntities<T1, T2, T3, T4, T5,
            T6, T7, T8, T9, T10, T11, T12, T13>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> FindEntities<T1, T2, T3, T4,
            T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FindEntities<T1, T2, T3,
            T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
                , (T15[])_components[Component<T15>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> FindEntities<T1,
            T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
                , (T15[])_components[Component<T15>.Index]
                , (T16[])_components[Component<T16>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> FindEntities<
            T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
                , (T15[])_components[Component<T15>.Index]
                , (T16[])_components[Component<T16>.Index]
                , (T17[])_components[Component<T17>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
            FindEntities<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(
                Component.GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
                , (T15[])_components[Component<T15>.Index]
                , (T16[])_components[Component<T16>.Index]
                , (T17[])_components[Component<T17>.Index]
                , (T18[])_components[Component<T18>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
            FindEntities<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,
                T19>(
                Component
                    .GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
                , (T15[])_components[Component<T15>.Index]
                , (T16[])_components[Component<T16>.Index]
                , (T17[])_components[Component<T17>.Index]
                , (T18[])_components[Component<T18>.Index]
                , (T19[])_components[Component<T19>.Index]
            );
        }


        public EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
            FindEntities<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>()
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
            return new EntityIterator<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,
                T19, T20>(
                Component
                    .GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
                        T20>(),
                _entitiesCount,
                _entities
                , (T1[])_components[Component<T1>.Index]
                , (T2[])_components[Component<T2>.Index]
                , (T3[])_components[Component<T3>.Index]
                , (T4[])_components[Component<T4>.Index]
                , (T5[])_components[Component<T5>.Index]
                , (T6[])_components[Component<T6>.Index]
                , (T7[])_components[Component<T7>.Index]
                , (T8[])_components[Component<T8>.Index]
                , (T9[])_components[Component<T9>.Index]
                , (T10[])_components[Component<T10>.Index]
                , (T11[])_components[Component<T11>.Index]
                , (T12[])_components[Component<T12>.Index]
                , (T13[])_components[Component<T13>.Index]
                , (T14[])_components[Component<T14>.Index]
                , (T15[])_components[Component<T15>.Index]
                , (T16[])_components[Component<T16>.Index]
                , (T17[])_components[Component<T17>.Index]
                , (T18[])_components[Component<T18>.Index]
                , (T19[])_components[Component<T19>.Index]
                , (T20[])_components[Component<T20>.Index]
            );
        }
    }
}