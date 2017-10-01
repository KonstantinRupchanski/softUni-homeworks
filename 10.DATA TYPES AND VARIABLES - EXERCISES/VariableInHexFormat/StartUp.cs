namespace VariableInHexFormat
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string hexValue = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexValue, 16));
        }
    }
}
