using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertFrom10ToN
{
    public class StartUp
    {
        public static void Main()
        {
            var systemAndNumber = Console.ReadLine().Split().ToArray();
            int system = int.Parse(systemAndNumber[0]);
            string inputNum = systemAndNumber[1];
            BigInteger number = BigInteger.Parse(inputNum);
            int length = inputNum.Length;
            var result = new StringBuilder(length);

            while (number != 0)
            {
                result.Append(number % system);
                number /= system;
            }
            string res = result.ToString();
            string revResult = ReverseString(res);
            Console.WriteLine(revResult);
        }
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
