using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L48_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Int64.Parse(Console.ReadLine());
            Int64 factorial = number;

            for (Int64 i = number - 1; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
