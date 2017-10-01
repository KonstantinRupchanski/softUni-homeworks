namespace _5_Different_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b - a < 4)
            {
                Console.WriteLine("No");
            }
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
//You will be given two numbers – a and b.Generate five numbers - n1, n2, n3, n4, n5, for which the following conditions are true: a ≤ n1<n2<n3<n4 ≤ n5 ≤ b.If there is no number in the given interval, which satisfies the conditions – print “No”.

//Input
//The input contains two integers, each on a new line.

//Output
//Print all numbers in increasing order and on a new line.

//Input Output
//3
//8	
//3 4 5 6 7
//3 4 5 6 8
//3 4 5 7 8
//3 4 6 7 8
//3 5 6 7 8
//4 5 6 7 8