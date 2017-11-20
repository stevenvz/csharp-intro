using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S6_L55_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            var nameArray = new char[(name.Length)];

            for (int i = 0; i < name.Length; i++)
            {
                nameArray[name.Length - i - 1] = name[i];
            }

            var reverse = string.Join("", nameArray);
            Console.WriteLine(reverse);
        }
    }
}
