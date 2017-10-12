using System;
using System.Linq;

namespace CompareCharArrays
{
    public class StartUp
    {
        public static void Main()
        {
            char[] arr1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] arr2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            
            if (arr1.Length > arr2.Length)
            {
                PrintResult(arr2, arr1);
                return;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2[i] < arr1[i])
                {
                    PrintResult(arr2, arr1);
                    return;
                }
            }
            PrintResult(arr1, arr2);
        }

        private static void PrintResult(char[] arr1, char[] arr2)
        {
            Console.WriteLine(string.Join("", arr1));
            Console.WriteLine(string.Join("", arr2));
        }
    }
}
