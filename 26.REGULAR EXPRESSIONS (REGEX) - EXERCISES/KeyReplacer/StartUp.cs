using System;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    public class StartUp
    {
        public static void Main()
        {
            string[] key = Console.ReadLine().Split(new char[] { '|', '\\', '<' }, StringSplitOptions.RemoveEmptyEntries);
            string start = key[0];
            string end = key[key.Length - 1];

            string input = Console.ReadLine();

            string pattern = "(?<=" + start + ")(.*?)(?=" + end + ")";

            MatchCollection m = Regex.Matches(input, pattern);

            StringBuilder str = new StringBuilder();

            foreach (Match item in m)
            {
                if (!(item.Value.Contains(start) && item.Value.Contains(end)))
                {
                    str.Append(item.Value);
                }
            }
            Console.WriteLine(str.ToString().Length > 0 ? str.ToString() : "Empty result");
        }
    }
}
