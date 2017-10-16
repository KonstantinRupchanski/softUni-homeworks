using System;
using System.Linq;

namespace BombNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var allNums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var bombAndPower = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < allNums.Count; i++)
            {
                if (allNums[i] == bomb)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, allNums.Count - 1);
                    int lenght = right - left + 1;
                    allNums.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", allNums.Sum()));
        }
    }
}
