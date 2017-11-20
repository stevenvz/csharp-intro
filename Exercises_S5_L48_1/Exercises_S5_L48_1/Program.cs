using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L48_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
