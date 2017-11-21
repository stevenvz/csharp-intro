using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + System.IO.Path.GetExtension(path));
            Console.WriteLine("File Name: " + System.IO.Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + System.IO.Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + System.IO.Path.GetDirectoryName(path));
        }
    }
}
