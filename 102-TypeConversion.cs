namespace csharp_101
{
    class ProgramTypeConversion
    {
        static void _()
        {
            byte bA = 1;
            int iA = bA;
            Console.WriteLine("convert byte to int: {0}", iA); Console.WriteLine(iA.GetType());

            int iB = 1000;
            byte bB = (byte) iB;
            Console.WriteLine("convert int to byte: {0}", bB); Console.WriteLine(bB.GetType()); // not work, missing 1 bit but max byte is 255

            var vC = "1234";
            int iC = Convert.ToInt32(vC);
            Console.WriteLine("convert var to int: {0}", iC); Console.WriteLine(iC.GetType());

            /*var vd = "1234";
            byte bd = Convert.ToByte(vd);
            Console.WriteLine("convert var to byte: {0}", bd); // not work is stack overflows*/

            string sE = "true";
            bool bE = Convert.ToBoolean(sE);
            Console.WriteLine("convert str to bool: {0}", bE); Console.WriteLine(bE.GetType());
        }
    }
}
