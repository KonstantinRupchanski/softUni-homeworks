using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem03
{
    public class StartUp
    {
        public static void Main()
        {
            string encoded = Console.ReadLine();
            string placeholders = Console.ReadLine();

            var separators = FindSeparators(encoded);
            var holders = ParsePlaceholders(placeholders);

            string result = encoded;
            for (int i = 0; i < separators.Count; i++)
            {
                result = Regex.Replace(result, $"{separators[i]}(.+){separators[i]}",
                   $"{separators[i]}{holders[i]}{separators[i]}");
            }
            Console.WriteLine(result);
        }

        static List<string> FindSeparators(string encoded)
        {
            List<string> separatorsList = new List<string>();

            StringBuilder searchBuilder = new StringBuilder();

            string lastHit = null;
            for (var i = 0; i < encoded.Length; i++)
            {
                char c = encoded[i];
                string rest = encoded.Substring(i);
                if (!Char.IsLetter(c))
                {
                    if (!string.IsNullOrEmpty(lastHit))
                    {
                        i += rest.LastIndexOf(lastHit) + lastHit.Length;
                        separatorsList.Add(lastHit);
                        lastHit = null;
                        searchBuilder.Clear();
                    }
                    continue;
                }
                searchBuilder.Append(c);
                if (rest.Contains(searchBuilder.ToString()))
                {
                    lastHit = searchBuilder.ToString();
                }
                else
                {
                    if (!string.IsNullOrEmpty(lastHit))
                    {
                        i += rest.LastIndexOf(lastHit) + lastHit.Length;
                        separatorsList.Add(lastHit);
                        lastHit = null;
                        searchBuilder.Clear();
                    }
                }

            }

            return separatorsList;
        }

        static List<string> ParsePlaceholders(string placeholders)
        {
            Regex r = new Regex(@"\{(?<grp>.+?)\}");

            List<string> matchesList = new List<string>();

            foreach (var match in r.Matches(placeholders).Cast<Match>())
            {
                matchesList.Add(match.Groups["grp"].Value);
            }
            return matchesList;
        }
    }
}
