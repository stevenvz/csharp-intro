using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S6_L55_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                var number = Int32.Parse(Console.ReadLine());

                while (true)
                {
                    if (numbers.Contains(number))
                    {
                        Console.Write("Retry: ");
                        number = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        numbers.Add(number);
                        break;
                    }
                }
            }

            numbers.Sort();

            foreach (var n in numbers)
                Console.Write(n + " ");

            Console.WriteLine();
        }
    }
}
