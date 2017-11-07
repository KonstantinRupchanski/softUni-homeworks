using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split(new string[] { " ", "\t", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim())
                .ToList();

            string input = string.Empty;
            while (!(input = Console.ReadLine()).Equals("3:1"))
            {
                string[] commandArgs = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandArgs[0];

                switch (command)
                {
                    case "merge":
                        collection = Merge(collection, Convert.ToInt32(commandArgs[1]),
                            Convert.ToInt32(commandArgs[2]));
                        break;

                    case "divide":
                        collection = Divide(collection, Convert.ToInt32(commandArgs[1]), Convert.ToInt32(commandArgs[2]));
                        break;
                }
            }

            PrintCollection(collection);
        }

        private static List<string> Merge(List<string> collection, int startIndex, int endIndex)
        {
            StringBuilder merged = new StringBuilder(collection[startIndex]).Append(collection[endIndex]);
            //List<string> asd = collection.Concat(collection[startIndex], collection[endIndex]);
            List<string> portion = collection.GetRange(startIndex, endIndex);


            return collection;
        }

        private static List<string> Divide(List<string> collection, int index, int partitions)
        {
            return collection;
        }


        private static void PrintCollection(List<string> collection)
        {
            Console.WriteLine($"{string.Join(" ", collection)}");
        }
    }
}
