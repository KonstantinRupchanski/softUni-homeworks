namespace MaxMethod
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int bigger = GetMax(numOne, numTwo);
            int max = Math.Max(bigger, numThree);
            Console.WriteLine(max);
        }

        private static int GetMax(int numOne, int numTwo)
        {
            return Math.Max(numOne, numTwo);
        }

    }
}