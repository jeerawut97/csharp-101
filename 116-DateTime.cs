using System;

namespace csharp_101
{

    class ProgramDateTime
    {
        static void _(string[] _)
        {
            var dateTime = new DateTime(2024, 07, 31);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
