using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L42_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter image width:");
            var width = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter image height:");
            var height = Int32.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            else if (width < height)
            {
                Console.WriteLine("The image is portrait.");
            }
            else
            {
                Console.WriteLine("The image is square!");
            }
        }
    }
}
