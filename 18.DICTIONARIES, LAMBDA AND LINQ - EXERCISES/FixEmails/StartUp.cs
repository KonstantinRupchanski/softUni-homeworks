using System;
using System.Collections.Generic;

namespace FixEmails
{
    public class StartUp
    {
        public static void Main()
        {
            var contacts = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "stop")
            {
                var currentName = input;
                input = Console.ReadLine();
                var check = input.Substring(input.Length - 2).ToLower();

                if (check != "us" && check != "uk")
                {
                    contacts[currentName] = input;
                }
                input = Console.ReadLine();

            }
            foreach (var name in contacts)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }
    }
}
