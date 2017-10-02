namespace IntegerToHexAndBinary
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int decimalNum = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(decimalNum, 16);
            ////or
            //string hexValue = decimalNum.ToString("X");
            string binary = Convert.ToString(decimalNum, 2);
            Console.WriteLine(hexValue.ToUpper());
            Console.WriteLine(binary);
        }
    }
}
