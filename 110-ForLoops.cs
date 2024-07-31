using System;

namespace csharp_101
{

    class ProgramForLoops
    {
        static void _(string[] _)
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            for (var i = 10; i >= 10; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
