//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Phonebook
//{
//    public class StartUp
//    {
//        public static void Main()
//        {
//            var phonebook = new Dictionary<string, string>();
//            var input = Console.ReadLine();

//            while (input != "END")
//            {
//                var phoneParam = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//                var command = phoneParam[0];

//                if (command == "A")
//                {
//                    var key = phoneParam[1];
//                    var val = phoneParam[2];

//                    phonebook[key] = val;

//                }
//                else if (command == "S")
//                {
//                    var key = phoneParam[1];

//                    if (phonebook.ContainsKey(key))
//                    {

//                        Console.WriteLine($"{key} -> {phonebook[key]}");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Contact {key} does not exist.");

//                    }
//                }
//                input = Console.ReadLine();
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else
                {

                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine(input[1] + " -> " + phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}