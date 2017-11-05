using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = $@"(?<=\s)([a-z0-9]+([-.]\w*)*)@([a-z]+([-.]\w*)*(\.[a-z]+))";
            var emails = Regex.Matches(text, pattern);
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
