using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S8_L67_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a series of numbers separated by dashes: ");
            var input = Console.ReadLine();

            var current = 0;
            var last = 0;
            bool consecutive = true;

            string[] values = input.Split('-');

            foreach (string item in values)
            {
                current = Int32.Parse(item);
                if (current >= last)
                {
                    last = current;
                }
                else
                {
                    last = current;
                    consecutive = false;
                }
            }

            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
