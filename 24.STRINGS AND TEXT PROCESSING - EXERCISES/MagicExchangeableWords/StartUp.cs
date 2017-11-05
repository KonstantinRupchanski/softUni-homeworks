using System;
using System.Linq;

namespace MagicExchangeableWords
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string wordOne = input[0];
            string wordTwo = input[1];

            var arrOne = wordOne.ToCharArray().Distinct().ToArray();
            var arrTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if (arrOne.Length == arrTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
