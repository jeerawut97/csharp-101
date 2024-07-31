using System;

namespace csharp_101
{

    class ProgramWhileLoops
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: {0}", input);
                    continue;
                }

                break;
            }
        }
    }
}
