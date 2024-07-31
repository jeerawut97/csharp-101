using System;

namespace csharp_101
{
    public class PersonRef
    {
        public int Age;
    }
    class ProgramReference
    {
        static void _(string[] _)
        {
            // Non Ref
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            // Ref
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0] {1}", array1[0], array2[0]));

            var person = new PersonRef() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void Decrement(int number)
        {
            number -= 10;
        }

        public static void MakeOld(PersonRef person)
        {
            person.Age += 10;
        }
    }
}
