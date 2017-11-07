using System;
using System.Linq;
using System.Numerics;

namespace Problem01
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfWebsitesDown = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < numberOfWebsitesDown; i++)
            {
                var items = Console.ReadLine().Split(' ').ToList();
                var numOne = decimal.Parse(items[1]);
                var numTwo = decimal.Parse(items[2]);
                decimal sum = numTwo * numOne;
                totalLoss += sum;
                Console.WriteLine(items[0]);
            }

            var result = BigInteger.Pow(securityKey, numberOfWebsitesDown);
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {result}");
        }
    }
}
