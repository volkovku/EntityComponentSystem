namespace ECS
{
    public static partial class Component
    {
        public static long GetTags<T1>()
            where T1 : struct
        {
            return
                Component<T1>.Tag;
        }

        public static long GetTags<T1, T2>()
            where T1 : struct
            where T2 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag;
        }

        public static long GetTags<T1, T2, T3>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
            where T7 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8>()
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
            where T7 : struct
            where T8 : struct
        {
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag | Component<T15>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag | Component<T15>.Tag | Component<T16>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag | Component<T15>.Tag | Component<T16>.Tag |
                Component<T17>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag | Component<T15>.Tag | Component<T16>.Tag |
                Component<T17>.Tag | Component<T18>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,
            T19>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag | Component<T15>.Tag | Component<T16>.Tag |
                Component<T17>.Tag | Component<T18>.Tag | Component<T19>.Tag;
        }

        public static long GetTags<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20>()
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
            return
                Component<T1>.Tag | Component<T2>.Tag | Component<T3>.Tag | Component<T4>.Tag |
                Component<T5>.Tag | Component<T6>.Tag | Component<T7>.Tag | Component<T8>.Tag |
                Component<T9>.Tag | Component<T10>.Tag | Component<T11>.Tag | Component<T12>.Tag |
                Component<T13>.Tag | Component<T14>.Tag | Component<T15>.Tag | Component<T16>.Tag |
                Component<T17>.Tag | Component<T18>.Tag | Component<T19>.Tag | Component<T20>.Tag;
        }
    }
}