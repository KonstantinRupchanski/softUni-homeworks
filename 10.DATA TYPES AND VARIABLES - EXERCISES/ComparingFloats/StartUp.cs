namespace ComparingFloats
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal difference = Math.Abs(firstNum - secondNum);
            decimal eps = 0.000001M;
            if (difference >= 0)
            {
                if (difference < eps)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (difference < 0)
            {
                if (difference < eps)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}
