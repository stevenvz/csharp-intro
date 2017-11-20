using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L48_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            while (true)
            {
                Console.Write("Enter a number, or \"ok\" tp exit: ");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    Console.WriteLine(sum);
                    break;
                }

                sum += Int32.Parse(input);
            }
        }
    }
}
