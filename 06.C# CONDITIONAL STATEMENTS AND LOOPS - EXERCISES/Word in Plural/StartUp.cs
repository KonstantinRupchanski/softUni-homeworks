namespace Word_in_Plural
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string noun = Console.ReadLine();
            bool endsWithY = noun.EndsWith("y");
            bool endsWithOuther = noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") ||
                                  noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z");
            if (endsWithY)
            {
                noun = noun.Remove(noun.Length - 1);
                noun += "ies";
            }
            else if (endsWithOuther)
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun);
        }
    }
}
