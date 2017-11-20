using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S8_L67_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var duplicate = false;

            while (true)
            {
                Console.Write("Enter a series of numbers separated by dashes: ");
                var input = Console.ReadLine();
                
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string[] values = input.Split('-');
                var valuesList = new List <int>();

                for(int i = 0; i < values.Length; i++)
                {
                    int current = Int32.Parse(values[i]);
                    if (valuesList.Contains(current))
                    {
                        duplicate = true;
                        break;
                    }
                    valuesList.Add(current);
                }

                break;
            }

            if (duplicate)
            {
                Console.WriteLine("Duplicate");
            }


        }
    }
}
