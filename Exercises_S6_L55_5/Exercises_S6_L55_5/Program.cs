using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S6_L55_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a series of numbers separated by commas (minimum length 5): ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List. Try Again.");
                }
                else
                {
                    string[] values = input.Split(',');

                    foreach (string item in values)
                    {
                        numbers.Add(Int32.Parse(item));
                    }

                    if (numbers.Count < 5)
                    {
                        Console.WriteLine("Invalid List. Try Again.");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            numbers.Sort();

            for (var i = 0; i < 3; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
