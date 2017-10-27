using System;
using System.IO;
using System.Linq;

namespace EqualSums
{
    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool equalSumsFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                int[] leftSide = input.Take(i).ToArray();
                int[] rightSide = input.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("output.txt", i.ToString());
                    equalSumsFound = true;
                    break;
                }
            }

            if (!equalSumsFound)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
