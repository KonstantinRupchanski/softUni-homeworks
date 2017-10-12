using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] arr = new bool[n + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (arr[i])
                {
                    for (int j = i * i; j < arr.Length; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }

            List<int> result = new List<int>();
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}