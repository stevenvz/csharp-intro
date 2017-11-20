using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L48_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random().Next(1, 10);
            var won = false;

            //Console.WriteLine(random);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess a number from 1 - 10: ");
                var guess = Int32.Parse(Console.ReadLine());

                if (guess == random)
                {
                    Console.WriteLine("You won");
                    won = true;
                    break;
                }
            }

            if (!won)
                Console.WriteLine("You lost");
        }
    }
}
