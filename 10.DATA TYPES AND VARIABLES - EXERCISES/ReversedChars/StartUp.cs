namespace ReversedChars
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            char charThree = char.Parse(Console.ReadLine());
            Console.Write($"{charThree}{charTwo}{charOne}");
        }
    }
}
