using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Exercises_S9_L75_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\data\file.txt";

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var contentArray = content.Split(' ');

                Console.WriteLine(contentArray.Length);
            }
            
        }
    }
}
