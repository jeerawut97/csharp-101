using System;

namespace csharp_101 {
    public enum ShippingMethod { 
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class ProgramEnums
    {
        static void Main(string[] _)
        {
            var method = ShippingMethod.RegularAirMail;
            Console.WriteLine(method);
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
