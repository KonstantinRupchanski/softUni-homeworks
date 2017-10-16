using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    public class StartUp
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var longestSeq = FindLIS(sequence);

            Console.WriteLine($"{string.Join(" ", longestSeq)}");
        }

        private static int[] FindLIS(int[] sequence)
        {
            int[] lenght = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                lenght[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && lenght[j] >= lenght[i])
                    {
                        lenght[i] = 1 + lenght[j];
                        prev[i] = j;
                    }
                }

                if (lenght[i] > maxLength)
                {
                    maxLength = lenght[i];
                    lastIndex = i;
                }

            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
