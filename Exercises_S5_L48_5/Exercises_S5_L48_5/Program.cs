using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L48_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a series of numbers separated by commas: ");
            var input = Console.ReadLine();
            
            var max = 0;

            string[] values = input.Split(',');

            foreach (string item in values)
            {
                if (Int32.Parse(item) > max)
                {
                    max = Int32.Parse(item);
                }
            }

            Console.WriteLine(max);
        }
    }
}
