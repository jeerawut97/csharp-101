using System;

namespace csharp_101
{

    class ProgramForeachLoops
    {
        static void _(string[] _)
        {
            var name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine();

            foreach (var charactor in name)
            {
                Console.WriteLine(charactor);
            }

            Console.WriteLine();

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
