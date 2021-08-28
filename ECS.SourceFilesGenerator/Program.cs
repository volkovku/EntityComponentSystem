using System;

namespace ECS.SourceFilesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Size());
            //Console.WriteLine(GenerateEntityIterators.GenerateIterators(20));
            //Console.WriteLine(GenerateEntityIteratorConstructors.GenerateConstructors(20));
        }

        public unsafe static int Size()
        {
            return sizeof(S);
        }

        struct S
        {
            public int I1;
            public int I2;
        }
    }
}