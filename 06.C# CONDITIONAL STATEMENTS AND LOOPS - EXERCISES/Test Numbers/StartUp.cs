namespace Test_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int lineOneN = int.Parse(Console.ReadLine());
            int lineTwoM = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;
            for (int i = lineOneN; i >= 1; i--)
            {
                for (int j = 1; j <= lineTwoM; j++)
                {
                    sum += 3 * (i * j);
                    combinations++;
                    if (sum >= magicNum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {magicNum}");
                        return;
                    }
                }
            }
            if (sum < magicNum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
