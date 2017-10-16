using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    public class StartUp
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var counter = 1;
            var number = 0;
            var maxCount = 1;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        number = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            if (maxCount == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
