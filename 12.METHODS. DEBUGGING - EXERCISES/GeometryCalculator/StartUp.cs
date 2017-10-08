namespace GeometryCalculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                decimal triangleSide = decimal.Parse(Console.ReadLine());
                decimal triangleHeight = decimal.Parse(Console.ReadLine());
                TriangleArea(triangleSide, triangleHeight);
            }

            if (figureType == "square")
            {
                decimal squareSide = decimal.Parse(Console.ReadLine());
                SquareArea(squareSide);
            }

            if (figureType == "rectangle")
            {
                decimal rectangleWidth = decimal.Parse(Console.ReadLine());
                decimal rectangleHeight = decimal.Parse(Console.ReadLine());
                RectangleArea(rectangleWidth, rectangleHeight);
            }

            if (figureType == "circle")
            {
                decimal cicleRadius = decimal.Parse(Console.ReadLine());
                CircleArea(cicleRadius);
            }
        }

        private static void CircleArea(decimal cicleRadius)
        {
            decimal circleArea = (decimal)Math.PI * cicleRadius * cicleRadius;
            Console.WriteLine($"{circleArea:F2}");
        }

        private static void RectangleArea(decimal rectangleWidth, decimal rectangleHeight)
        {
            decimal rectangleArea = rectangleWidth * rectangleHeight;
            Console.WriteLine($"{rectangleArea:F2}");
        }

        private static void SquareArea(decimal squareSide)
        {
            decimal squareArea = squareSide * squareSide;
            Console.WriteLine($"{squareArea:F2}");
        }

        private static void TriangleArea(decimal triangleSide, decimal triangleHeight)
        {
            decimal triangleArea = (triangleSide * triangleHeight) / 2;
            Console.WriteLine($"{triangleArea:F2}");
        }
    }
}
