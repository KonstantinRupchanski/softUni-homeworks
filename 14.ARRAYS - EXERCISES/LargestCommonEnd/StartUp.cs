namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var arr2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var lenght = Math.Min(arr1.Length, arr2.Length);

            var leftCounter = 0;
            var rightCounter = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftCounter++;
                }
                if (arr1[arr1.Length - i - 1] == arr2[arr2.Length - i - 1])
                {
                    rightCounter++;
                }
            }
            Console.WriteLine(Math.Max(leftCounter,rightCounter));





            //    var first = Console.ReadLine()
            //        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();
            //    var second = Console.ReadLine()
            //        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();
            //    var startCount = CountCommonItems(first, second);
            //    var endCount = CountCommonItems(first.Reverse()
            //        .ToArray(), second
            //        .Reverse()
            //        .ToArray());
            //    Console.WriteLine($"{Math.Max(startCount, endCount)}");
            //}

            //private static int CountCommonItems(string[] first, string[] second)
            //{
            //    int lenght = Math.Min(first.Length, second.Length);
            //    int count = 0;
            //    for (int i = 0; i < lenght; i++)
            //    {
            //        if (first[i] == second[i])
            //        {
            //            count++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    return count;
        }
    }
}