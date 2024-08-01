using System;

namespace csharp_101
{

    class ProgramTimeSpan
    {
        static void _(string[] _)
        {
            // Creating
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: {0}", duration);

            // Properties
            Console.WriteLine("Minutes: {0}", timeSpan.Minutes);
            Console.WriteLine("Total Minutes: {0}", timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: {0}", timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: {0}", timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            // ToString
            Console.WriteLine("ToString: {0}", timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: {0}", TimeSpan.Parse("01:02:03"));
        }
    }
}
