namespace PrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i ++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
