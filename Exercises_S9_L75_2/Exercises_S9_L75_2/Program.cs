using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises_S9_L75_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 0;
            var index = 0;
            var path = @"C:\data\file.txt";

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var contentArray = content.Split(' ');

                foreach (var item in contentArray)
                {
                    if (item.Length > length)
                    {
                        length = item.Length;
                        index = Array.IndexOf(contentArray, item);
                    }
                }

                Console.WriteLine(contentArray[index]);
            }
        }
    }
}
