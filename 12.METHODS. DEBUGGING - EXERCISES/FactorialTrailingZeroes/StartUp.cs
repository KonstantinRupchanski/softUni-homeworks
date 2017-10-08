namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            CountOfZeroes(n);
        }

        private static void CountOfZeroes(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            string text = factorial.ToString();
            int count = text.Length - text.TrimEnd('0').Length;
            Console.WriteLine(count);
        }
    }
}
