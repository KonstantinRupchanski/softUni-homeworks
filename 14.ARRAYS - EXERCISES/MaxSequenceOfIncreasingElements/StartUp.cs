using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                MaxSeqOfEqElements();
                Console.WriteLine("Try another? (yes/no)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;


            }


        }

        private static void MaxSeqOfEqElements()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var count = 1;
            var bestCount = 0;
            var bestIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i - count;
                }
            }
            for (int i = bestIndex; i < bestIndex + bestCount; i++)
            {
                Console.Write(arr[i + 1] + " ");
            }
            Console.WriteLine();
        }
    }
}
