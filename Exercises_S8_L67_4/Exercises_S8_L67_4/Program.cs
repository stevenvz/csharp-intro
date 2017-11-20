using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S8_L67_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine().ToLower();

            var text = input.Split(' ');

            var textList = new List<string>();

            foreach (var item in text)
            {
                var word = new StringBuilder(item);
                word[0] = (char)(word[0] - 32);
                textList.Add(word.ToString());
            }

            var final = String.Join(String.Empty, textList.ToArray());

            Console.WriteLine(final);

        }
    }
}
