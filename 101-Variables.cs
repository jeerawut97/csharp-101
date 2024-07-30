
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            var numberVar = 2;
            var countVar = 10;
            var totalPriceVar = 20.95f;
            var characterVar = 'A';
            var firstNameVar = "Mosh";
            var isWorkingVar = false;

            Console.WriteLine(numberVar);
            Console.WriteLine(countVar);
            Console.WriteLine(totalPriceVar);
            Console.WriteLine(characterVar);
            Console.WriteLine(firstNameVar);
            Console.WriteLine(isWorkingVar);
        }
    }
}
