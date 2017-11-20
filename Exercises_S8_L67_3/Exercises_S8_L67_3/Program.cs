using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.DateTime;

namespace Exercises_S8_L67_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time in 24-hr format (ie. 19:00): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                var timeArray = input.Split(':');
                if (timeArray.Length != 2)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    var hour = Int32.Parse(timeArray[0]);
                    var minute = Int32.Parse(timeArray[1]);

                    if ((hour >= 0 && hour < 24) &&
                        (minute >= 0 && minute < 60))
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                
            }
        }
    }
}
