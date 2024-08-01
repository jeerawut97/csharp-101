using System.IO;

namespace csharp_101
{

    class ProgramPath
    {
        static void Main(string[] _)
        {
            var path = @"C:\Users\jeerawut.j\source\repos\csharp-101\101-Variables.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: {0}", Path.GetExtension(path));
            Console.WriteLine("File Name: {0}", Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: {0}", Path.GetDirectoryName(path));
        }
    }
}
