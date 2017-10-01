namespace BooleanVariable
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string yesNo = Console.ReadLine();
            if (Convert.ToBoolean(yesNo) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
