using System;

namespace csharp_101
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class ProgramConditionals
    {
        static void Main(string[] args)
        {
            // if else base
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour > 12 && hour < 18) 
            {
                Console.WriteLine("It's afternoon");
            } else
            {
                Console.WriteLine("It's evening");
            }

            // if else one line
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            // switch case
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's srping");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer");
                    break;
                default:
                    Console.WriteLine("It's winter");
                    break;
            }

        }
    }
}
