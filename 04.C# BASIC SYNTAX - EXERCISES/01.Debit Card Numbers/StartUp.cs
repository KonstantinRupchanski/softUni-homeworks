namespace Exercises
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}");
        }
    }
}
