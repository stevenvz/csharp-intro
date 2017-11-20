using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L42__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 - 10:");
            var input = Int32.Parse(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
