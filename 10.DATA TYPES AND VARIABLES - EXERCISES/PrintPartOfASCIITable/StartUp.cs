namespace PrintPartOfASCIITable
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            byte fromNum = byte.Parse(Console.ReadLine());
            byte toNum = byte.Parse(Console.ReadLine());
            for (int i = fromNum; i <= toNum; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
