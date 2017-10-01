using System;

namespace _04._Beverage_Labels
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double volumeInPerc = volume / 100;
            double energyPer100ml = double.Parse(Console.ReadLine())*volumeInPerc;
            double sugarPer100ml = double.Parse(Console.ReadLine())*volumeInPerc;
            Console.Write($"{volume}ml ");
            Console.WriteLine($"{name}:");
            Console.Write($"{energyPer100ml}kcal, ");
            Console.WriteLine($"{sugarPer100ml}g sugars");
        }
    }
}
