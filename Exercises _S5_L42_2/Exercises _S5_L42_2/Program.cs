using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__S5_L42_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            var num2 = Int32.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
