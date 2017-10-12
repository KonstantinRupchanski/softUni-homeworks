namespace FoldAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;
            int[] leftArr = numbers.Take(k).ToArray();
            int[] midArr = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = new int[k * 2];
            for (var i = 0; i < k; i++)
            {
                result[i] = midArr[i] + leftArr[i];
                result[i + k] = midArr[i + k] + rightArr[i];
            }
            Console.WriteLine($"{string.Join(" ",result)}");
        }
    }
}