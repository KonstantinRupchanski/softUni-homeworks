namespace Restaurant_Discount
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double totalPrice = 0;
            double discount = 0;
            double pricePerPerson = 0;

            if (groupSize <= 50)
            {
                if (package == "Normal")
                {
                    totalPrice = 2500 + 500;
                    discount = totalPrice - (totalPrice * 0.05);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = 2500 + 750;
                    discount = totalPrice - (totalPrice * 0.10);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = 2500 + 1000;
                    discount = totalPrice - (totalPrice * 0.15);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            if (groupSize > 50 && groupSize <= 100)
            {
                if (package == "Normal")
                {
                    totalPrice = 5000 + 500;
                    discount = totalPrice - (totalPrice * 0.05);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = 5000 + 750;
                    discount = totalPrice - (totalPrice * 0.10);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = 5000 + 1000;
                    discount = totalPrice - (totalPrice * 0.15);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            if (groupSize > 100 && groupSize <= 120)
            {
                if (package == "Normal")
                {
                    totalPrice = 7500 + 500;
                    discount = totalPrice - (totalPrice * 0.05);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = 7500 + 750;
                    discount = totalPrice - (totalPrice * 0.10);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = 7500 + 1000;
                    discount = totalPrice - (totalPrice * 0.15);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }

            }
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
