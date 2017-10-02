namespace FastPrimeChecker
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            uint numToCheck = uint.Parse(Console.ReadLine());
            for (int i = 2; i <= numToCheck; i++)
            {
                bool trueOrFalse = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        trueOrFalse = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {trueOrFalse}");
            }
        }
    }
}
