using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    public class StartUp
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            Regex r = new Regex(@"(?<str>.+?)(?<num>\d+)");

            StringBuilder final = new StringBuilder();

            var matches = r.Matches(input);

            foreach (Match match in matches)
            {
                for (int i = 0; i < Int32.Parse(match.Groups["num"].Value); i++)
                {
                    final.Append(match.Groups["str"].Value.ToUpper());
                }
            }
            var uniqueChars = final.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(final.ToString());
        }
    }
}
