﻿namespace Substring
{
    using System;

    public class StartUp
    {

        public static void Main()
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            const char Search = 'р';
            bool hasMatch = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = false;

                    int endIndex = count;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += count;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}