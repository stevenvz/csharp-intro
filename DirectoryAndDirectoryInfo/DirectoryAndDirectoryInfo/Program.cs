using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "'.'", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
