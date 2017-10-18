using System;
using System.Collections.Generic;

namespace AMinerTask
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resources = new Dictionary<string, int>();

            while (input != "stop")
            {

                var currentItem = input;
                input = Console.ReadLine();

                if (!resources.ContainsKey(currentItem))
                {
                    resources.Add(currentItem, 0);
                }
                resources[currentItem] += int.Parse(input);
                input = Console.ReadLine();
            }

            foreach (var stone in resources)
            {
                Console.WriteLine($"{stone.Key} -> {stone.Value}");
            }
        }
    }
}
