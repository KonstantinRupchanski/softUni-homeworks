using System;
using System.Linq;

namespace SearchForANumber
{
    public class StartUp
    {
        public static void Main()
        {
            var numsList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numsList = numsList.Take(arr[0]).ToList();

            var numToDelete = arr[1];

            for (int i = 0; i < numToDelete; i++)
            {
                numsList.Remove(numsList[i - i]);
            }

            if (numsList.Contains(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
