using System;
using System.Linq;

namespace PairsByDifference
{
    public class StartUp
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var difference = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
