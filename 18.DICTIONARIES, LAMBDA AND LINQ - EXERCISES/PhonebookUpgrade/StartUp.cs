using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PhonebookUpgrade
{
    public class StartUp
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var phoneParam = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = phoneParam[0];

                if (command == "A")
                {
                    var key = phoneParam[1];
                    var val = phoneParam[2];

                    phonebook[key] = val;

                }
                else if (command == "S")
                {
                    var key = phoneParam[1];

                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var str in phonebook)
                    {
                        Console.WriteLine($"{str.Key} -> {str.Value}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
