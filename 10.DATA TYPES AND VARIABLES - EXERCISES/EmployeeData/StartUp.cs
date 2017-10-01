namespace EmployeeData
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender =  char.Parse(Console.ReadLine());
            ulong personalIDnum = ulong.Parse(Console.ReadLine());
            int uniquieEmployeeNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalIDnum}");
            Console.WriteLine($"Unique Employee number: {uniquieEmployeeNum}");
        }
    }
}
