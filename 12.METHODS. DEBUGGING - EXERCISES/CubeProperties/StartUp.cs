namespace CubeProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            switch (type)
            {
                case "face":
                    Face(side);
                    break;
                case "space":
                    Space(side);
                    break;
                case "volume":
                    Volume(side);
                    break;
                case "area":
                    Area(side);
                    break;
            }
        }

        private static void Area(double side)
        {
            double result = 6 * Math.Pow(side, 2);
            Console.WriteLine($"{result:F2}");
        }

        private static void Volume(double side)
        {
            double result = Math.Pow(side, 3);
            Console.WriteLine($"{result:F2}");
        }

        private static void Space(double side)
        {
            double result = Math.Sqrt(3 * Math.Pow(side, 2));
            Console.WriteLine($"{result:F2}");
        }

        public static void Face(double side)
        {
            double result = Math.Sqrt(2 * Math.Pow(side, 2));
            Console.WriteLine($"{result:F2}");
        }
    }
}
