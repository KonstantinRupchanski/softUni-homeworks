namespace FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibNum(n));
        }

        public static int FibNum(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int sum = a;
                a = b;
                b = sum + b;
            }
            return b;
        }
    }
}
