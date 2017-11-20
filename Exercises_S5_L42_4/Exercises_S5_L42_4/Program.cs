using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L42_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit:");
            var speedLimit = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the car's speed:");
            var carSpeed = Int32.Parse(Console.ReadLine());

            int demerits = (carSpeed - speedLimit) / 5;

            if (demerits <= 0 && carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (demerits >= 0 && demerits <= 12)
            {
                Console.WriteLine(demerits);
            }
            else
            {
                Console.WriteLine("License Suspended");
            }
        }
    }
}
