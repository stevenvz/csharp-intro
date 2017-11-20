﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Steve";
            var lastName = "Zarrella";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);

            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
