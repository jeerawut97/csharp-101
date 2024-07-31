using System;

namespace csharp_101
{

    class ProgramLists
    {
        static void Main(string[] args)
        {
            // List is dynamic size

            var numbers = new List<int>() { 1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 1: {0}", numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: {0}", numbers.LastIndexOf(1));

            Console.WriteLine("Count: {0}", numbers.Count);

            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Clear();
            Console.WriteLine("Clear");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
