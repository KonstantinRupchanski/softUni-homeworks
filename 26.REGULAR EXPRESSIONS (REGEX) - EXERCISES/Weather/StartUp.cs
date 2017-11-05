using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"(?<city>[A-Z][A-Z])(?<temp>[0-9]+\.[0-9]+)(?<type>[A-Za-z]+)(?=\|)";

            Dictionary<string, Tuple<double, string>> dict = new Dictionary<string, Tuple<double, string>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                Match m = Regex.Match(input, pattern);

                if (m.Success)
                {
                    string city = m.Groups["city"].Value;
                    double temp = double.Parse(m.Groups["temp"].Value);
                    string type = m.Groups["type"].Value;
                    var tup = Tuple.Create(temp, type);
                    if (!dict.ContainsKey(city))
                    {
                        dict.Add(city, tup);
                    }
                    dict[city] = tup;
                }

                input = Console.ReadLine();
            }

            foreach (var city in dict.OrderBy(x => x.Value.Item1))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Item1:f2} => {city.Value.Item2}");
            }
        }
    }
}
