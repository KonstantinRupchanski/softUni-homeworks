namespace Interval_of_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne < numTwo)
            {
                for (int i = numOne; i <= numTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = numTwo; i <= numOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
