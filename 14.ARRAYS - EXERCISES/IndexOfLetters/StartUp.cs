using System;

namespace IndexOfLetters
{
    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();


            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {word[i]-97}");

            }
        }
    }
}
