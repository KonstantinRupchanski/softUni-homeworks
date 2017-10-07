namespace HelloName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            PrintName();
        }

        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
