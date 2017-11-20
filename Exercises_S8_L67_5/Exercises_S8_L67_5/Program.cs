using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S8_L67_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine();

            var count = 0;
            var textList = new List<char>();
            var builder = new StringBuilder(input);

            for (int i = 0; i < builder.Length; i++)
            {
                textList.Add(builder[i]);
                if (builder[i] == 'a' ||
                    builder[i] == 'e' ||
                    builder[i] == 'i' ||
                    builder[i] == 'o' ||
                    builder[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
