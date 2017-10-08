
namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;


    public class StartUp
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            checkForPrimes(num1, num2);
        }

        private static void checkForPrimes(int num1, int num2)
        {
            List<int> numbers = new List<int>();

            if (num1 > num2)
            {
                Console.WriteLine("empty list");
                return;
            }
            if (num1 <= 1 || num2 < 0)
            {
                num1 = 2;
            }
            for (int i = num1; i <= num2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    numbers.Add(i);
                }
            }
            print(numbers);
        }

        private static void print(List<int> numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }

    }
}
