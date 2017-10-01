namespace Count_the_Integers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int ints = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(ints);
                    return;
                }
                ints++;
            }
        }
    }
}
