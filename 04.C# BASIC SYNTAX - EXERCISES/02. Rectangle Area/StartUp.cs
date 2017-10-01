using System;

namespace _02._Rectangle_Area
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = w * h;
            Console.WriteLine($"{area:F2}");

        }
    }
}
