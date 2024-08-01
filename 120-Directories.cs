using System.IO;

namespace csharp_101
{

    class ProgramDirectories
    {
        static void Main(string[] _)
        {
            Directory.CreateDirectory(@"d:\temp\folder1");

            var files = Directory.GetFiles(@"C:\Users\jeerawut.j\source\repos\csharp-101", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\jeerawut.j\source\repos\csharp-101", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Console.WriteLine(Directory.Exists(@"d:\temp\folder1"));

            var directoryInfo = new DirectoryInfo(@"C:\Users\jeerawut.j\source\repos\csharp-101");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
