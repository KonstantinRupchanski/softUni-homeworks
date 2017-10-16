using System;
using System.Linq;

namespace ChangeList
{
    public class StartUp
    {
        public static void Main()
        {
            var listNums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var listCommands = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (listCommands[0] != "Odd" && listCommands[0] != "Even")
            {
                if (listCommands[0] == "Delete")
                {
                    int number = int.Parse(listCommands[1]);
                    listNums.RemoveAll(i => i == number);
                }
                else
                {
                    int element = int.Parse(listCommands[1]);
                    int position = int.Parse(listCommands[2]);
                    listNums.Insert(position,element);
                }
                listCommands = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            if (listCommands[0] == "Odd")
            {
                foreach (var odd in listNums)
                {
                    if (odd % 2 == 1)
                    {
                        Console.Write($"{odd} ");
                    }
                }
            }
            else
            {
                foreach (var even in listNums)
                {
                    if (even % 2 == 0)
                    {
                        Console.Write($"{even} ");
                    }
                }
            }
        }
    }
}
