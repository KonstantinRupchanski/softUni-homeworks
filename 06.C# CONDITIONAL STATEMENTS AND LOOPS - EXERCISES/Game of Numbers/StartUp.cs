namespace Game_of_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {sum}");
                        return;
                    }
                    combinations++;
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
        }
    }
}
