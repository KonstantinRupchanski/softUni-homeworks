using System.Linq;

namespace Hotel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            if ((month == "May" || month == "October") && numberOfNights <= 7)
            {
                Console.WriteLine($"Studio: {numberOfNights * 50:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 65:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 75:F2} lv.");
            }
            else if (month == "May" && numberOfNights > 7)
            {
                Console.WriteLine($"Studio: {numberOfNights * (50 * 0.95):F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 65:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 75:F2} lv.");
            }
            else if (month == "October" && numberOfNights > 7)
            {
                Console.WriteLine($"Studio: {(numberOfNights * (50 * 0.95)) - (50 * 0.95):F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 65:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 75:F2} lv.");
            }
            if (month == "June" && numberOfNights <= 14)
            {
                Console.WriteLine($"Studio: {numberOfNights * 60:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 72:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 82:F2} lv.");
            }
            else if (month == "September" && numberOfNights <= 7)
            {
                Console.WriteLine($"Studio: {numberOfNights * 60:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 72:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 82:F2} lv.");
            }
            else if (month == "June" && numberOfNights > 14)
            {
                Console.WriteLine($"Studio: {numberOfNights * 60:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * (72 * 0.90):F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 82:F2} lv.");
            }
            else if (month == "September" && numberOfNights > 7)
            {
                Console.WriteLine($"Studio: {(numberOfNights * 60) - 60:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 72:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 82:F2} lv.");
            }
            else if (month == "September" && numberOfNights > 14)
            {
                Console.WriteLine($"Studio: {(numberOfNights * 60) - 60:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * (72 * 0.90):F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 82:F2} lv.");
            }
            if ((month == "July" || month == "August" || month == "December") && numberOfNights <= 14)
            {
                Console.WriteLine($"Studio: {numberOfNights * 68:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 77:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * 89:F2} lv.");
            }
            else if ((month == "July" || month == "August" || month == "December") && numberOfNights > 14)
            {
                Console.WriteLine($"Studio: {numberOfNights * 68:F2} lv.");
                Console.WriteLine($"Double: {numberOfNights * 77:F2} lv.");
                Console.WriteLine($"Suite: {numberOfNights * (89 * 0.85):F2} lv.");
            }
        }
    }
}
