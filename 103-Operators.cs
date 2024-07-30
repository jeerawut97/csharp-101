namespace Operators
{
    class ProgramOperators
    {
        static void Main()
        {
            // Arithmetic Operators(+, -, *, /, %) Ex. a + b, a++ a--
            float a = 10;
            float b = 20;
            float c = a++;
            float d = b--;
            float e = a + b;
            float f = a - b;
            float g = a * c;
            float h = b / d;
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", a, b, c, d, e, f, g, h);
            Console.WriteLine();

            // Comparison Operators(==, !=, >, >=, <, <=) Ex. a == b
            Console.WriteLine("a == b: {0}, a != b: {1}, a > b: {2}, a >= b: {3}, a < b: {4}, a <= b" +
                ": {5}", a == b, a != b, a > b, a >= b, a < b, a <= b);
            Console.WriteLine();

            // Assignement Operators(=, +=, -=, *=, /=) Ex. a = b
            float i = h;
            Console.WriteLine("i: {0}", i);
            i += 2;
            Console.WriteLine("i: {0}", i);
            i -= 2;
            Console.WriteLine("i: {0}", i);
            i *= 2;
            Console.WriteLine("i: {0}", i);
            i /= 2;
            Console.WriteLine("i: {0}", i);
            Console.WriteLine();

            // Logical Operators(&&, ||, !) Ex. a && b
            Console.WriteLine("h > a && i < g: {0}", h > a && i < g);
            Console.WriteLine("h > a || i < g: {0}", h > a || i < g);
            Console.WriteLine("!(h > a || i < g): {0}", !(h > a || i < g));

            // Bitwise Operators(&, !) Ex. a & b
            var x = true;
            var y = !x;
            var z = (x & true) == true;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
