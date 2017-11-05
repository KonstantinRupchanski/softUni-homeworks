using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCoffeeOrders
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                var price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        public static decimal ReadOrderAndCalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:F2}");
            return price;
        }
    }
}
