using System;

namespace csharp_101
{

    class ProgramRandomClass
    {
        static void _(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine((char)random.Next(97, 122));
            }

            var buffer = new char[10];
            for (var i = 0; i < 10; ++i)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);

            Console.WriteLine("password: {0}", password);    
        }
    }
}
