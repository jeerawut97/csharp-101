using System;

namespace csharp_101
{

    class ProgramAdvanceArrays
    {
        static void _(string[] args)
        {
            // Array is fixed size

            var numbers = new[] { 3, 7, 9, 2 ,14, 6 };
            // Length
            Console.WriteLine("Length: {0}", numbers.Length);

            // IndexOf()
            Console.WriteLine("Index of 9: {0}", Array.IndexOf(numbers, 9));

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var i in numbers) Console.WriteLine(i);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var i in another) Console.WriteLine(i);

            //Sort()
            Console.WriteLine("Sorting");
            Array.Sort(numbers);
            foreach (var i in numbers) Console.WriteLine(i);

            //Reverse()
            Console.WriteLine("Reverse");
            Array.Reverse(another);
            foreach (var i in another) Console.WriteLine(i);
        }
    }
}
