using System;
using System.Collections.Generic;
using System.IO;

namespace IndexOfLetters
{
    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt")
                .ToCharArray();
            var output = new List<string>();

            foreach (var letter in input)
            {
                output.Add($"{letter} -> {letter - 'a'}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
