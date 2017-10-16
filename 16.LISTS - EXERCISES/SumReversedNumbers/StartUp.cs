using System;
using System.Linq;

namespace SumReversedNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                string input = arr[i];
                char[] inputarray = input.ToCharArray();
                Array.Reverse(inputarray);
                string output = new string(inputarray);
                sum += int.Parse(output);
            }
            Console.WriteLine(sum);
        }
    }
}