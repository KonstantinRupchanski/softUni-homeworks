
namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;


    public class StartUp
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            }
        }

        public static int IsPrime(int startNum, int endNum)
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
