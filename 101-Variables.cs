
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            Console.WriteLine(number); Console.WriteLine(number.GetType());
            Console.WriteLine(count); Console.WriteLine(count.GetType());
            Console.WriteLine(totalPrice); Console.WriteLine(totalPrice.GetType());
            Console.WriteLine(character); Console.WriteLine(character.GetType());
            Console.WriteLine(firstName); Console.WriteLine(firstName.GetType());
            Console.WriteLine(isWorking); Console.WriteLine(isWorking.GetType());
            Console.WriteLine("\n");

            var numberVar = 2;
            var countVar = 10;
            var totalPriceVar = 20.95f;
            var characterVar = 'A';
            var firstNameVar = "Mosh";
            var isWorkingVar = false;

            Console.WriteLine(numberVar); Console.WriteLine(numberVar.GetType());
            Console.WriteLine(countVar); Console.WriteLine(countVar.GetType());
            Console.WriteLine(totalPriceVar); Console.WriteLine(totalPriceVar.GetType());
            Console.WriteLine(characterVar); Console.WriteLine(characterVar.GetType());
            Console.WriteLine(firstNameVar); Console.WriteLine(firstNameVar.GetType());
            Console.WriteLine(isWorkingVar); Console.WriteLine(isWorkingVar.GetType());
            Console.WriteLine("\n");

            const float Pi = 3.14f;
            Console.WriteLine(Pi); Console.WriteLine(Pi.GetType());
            Console.WriteLine("\n");

            Console.WriteLine("byte min: {0}, byte max: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("short min: {0}, short max: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("int min: {0}, int max: {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("long min: {0}, long max: {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("float min: {0}, float max: {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double min: {0}, double max: {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal min: {0}, decimal max: {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
