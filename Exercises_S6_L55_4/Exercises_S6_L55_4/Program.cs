using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S6_L55_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var uniques = new List<int>();

                while (true)
                {
                    Console.Write("Enter a number, or \"Quit\" to exit: ");
                    var input = Console.ReadLine();

                    if (input == "Quit")
                        break;

                    var number = Int32.Parse(input);

                    if (!numbers.Contains(number))
                        uniques.Add(number);

                    numbers.Add(number);
                }

            foreach (var n in uniques)
                Console.Write(n + " ");

            Console.WriteLine();
        }
    }
}
