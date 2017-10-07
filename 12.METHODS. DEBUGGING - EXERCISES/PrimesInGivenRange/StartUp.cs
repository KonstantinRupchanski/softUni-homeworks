using System.Collections.Generic;

namespace PrimesInGivenRange
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            }
        }

        public static bool isPrime(int startNum, int endNum)
        {
        bool isPrime = true;
            for (int i = startNum; i <= 50; i++)
        {
            for (int j = 2; j <= 100; j++)
            {

                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                Console.Write($"{i}, ");
            }
            isPrime = true;

        }

    }
}
