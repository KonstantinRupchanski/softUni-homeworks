﻿using System;
using System.Linq;

namespace UnicodeCharacters
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);

            Console.WriteLine(result);
        }
    }
}
