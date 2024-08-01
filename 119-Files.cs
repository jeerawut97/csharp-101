using System.IO;

namespace csharp_101
{

    class ProgramFiles
    {
        static void Main(string[] _)
        {
            var path = @"";
            File.Copy(@"from", @"to", true);
            File.Delete(path);
            if (File.Exists(path)) 
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            fileInfo.OpenRead();
        }
    }
}
