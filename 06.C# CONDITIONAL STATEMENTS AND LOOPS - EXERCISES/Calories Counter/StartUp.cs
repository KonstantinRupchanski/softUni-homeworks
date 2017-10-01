namespace Calories_Counter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numOfIngredients = int.Parse(Console.ReadLine());
            int totalCal = 0;

            for (int i = 0; i < numOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCal += 500; break;
                    case "tomato sauce":
                        totalCal += 150; break;
                    case "salami":
                        totalCal += 600; break;
                    case "pepper":
                        totalCal += 50; break;
                }
            }
            Console.WriteLine($"Total calories: {totalCal}");
        }
    }
}
