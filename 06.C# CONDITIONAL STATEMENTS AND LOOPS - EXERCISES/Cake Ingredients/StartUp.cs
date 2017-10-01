namespace Cake_Ingredients
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numOfIngr = 0;

            for (int i = 0; i < 1;)
            {
                string ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numOfIngr} ingredients.");
                    break;
                }
                else
                {
                    numOfIngr++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
        }
    }
}
