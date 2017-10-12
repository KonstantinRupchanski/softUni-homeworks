//using System;
//using System.Linq;

//namespace MostFrequentNumber
//{
//    public class StartUp
//    {
//        public static void Main()
//        {
//            var arr = Console.ReadLine()
//                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                .Select(int.Parse)
//                .ToArray();
//            var counter = 1;
//            var sameSigns = 0;
//            var bestCount = 1;
//            var bestSign = 1;


//            for (int i = 0; i < arr.Length; i++)
//            {
//                for (int j = i; j < arr.Length; j++)
//                {
//                    if (arr[i] == arr[j])
//                    {
//                        sameSigns = arr[i];
//                        counter++;
//                    }
//                    if (counter > bestCount)
//                    {
//                        bestSign = sameSigns;
//                        bestCount = counter;
//                    }
//                }
//                counter = 1;
//            }
//            Console.WriteLine(bestSign);
//        }
//    }
//}


namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int n = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count())
                .OrderByDescending(x => x.Value)
                .First()
                .Key;

            Console.WriteLine(n);
        }
    }
}