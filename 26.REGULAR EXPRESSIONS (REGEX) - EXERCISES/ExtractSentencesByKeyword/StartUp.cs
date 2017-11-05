using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    public class StartUp
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var sentences = text.Split(new char[] { '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var pattern = $@"\b{word}\b";


            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
