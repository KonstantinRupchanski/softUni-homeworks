namespace CenterPoint
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            CloserDotToMid(x1, y1, x2, y2);
        }

        public static void CloserDotToMid(double x1, double y1, double x2, double y2)
        {
            double dotOne = Math.Abs(Math.Sqrt(x1 * x1) + (y1 * y1));
            double dotTwo = Math.Abs(Math.Sqrt(x2 * x2) + (y2 * y2));

            if (dotOne < dotTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}