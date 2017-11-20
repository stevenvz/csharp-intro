using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S6_L55_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name (or just <enter> to stop): ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);
            }

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(names[0] + " likes your post");
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], (names.Count - 2));
                    break;
            }
            
        }
    }
}
