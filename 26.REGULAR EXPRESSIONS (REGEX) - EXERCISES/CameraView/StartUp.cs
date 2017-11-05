using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    public class StartUp
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var countOfElementsToSkip = firstLine[0];
            var countOfElementsToTake = firstLine[1];
            var text = Console.ReadLine();
            var camera = $@"(?<=\|\<)[\w]+";
            var matchedText = Regex.Matches(text, camera);
            List<string> wordsLeft = new List<string>();

            foreach (Match match in matchedText)
            {
                var leftToPrint = new string(match.Value.Skip(countOfElementsToSkip).Take(countOfElementsToTake).ToArray());
                wordsLeft.Add(leftToPrint);
            }
            Console.Write(string.Join(", ", wordsLeft));
        }
    }
}
