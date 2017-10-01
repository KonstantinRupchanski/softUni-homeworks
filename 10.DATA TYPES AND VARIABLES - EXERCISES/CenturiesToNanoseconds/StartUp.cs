namespace CenturiesToNanoseconds
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            //Console.WriteLine("Please write down the centuriers(number) and press `Enter`.");
            int centuries = int.Parse(Console.ReadLine());
            uint years = (uint)centuries * 100;
            double days = (double)Math.Floor(years*365.2422);
            uint hours = (uint) days * 24;
            ulong minutes = (ulong) hours * 60;
            ulong seconds = (ulong) minutes * 60;
            ulong milliseconds = (ulong) seconds * 1000;
            decimal microseconds = (decimal) milliseconds * 1000;
            decimal nanoseconds = (decimal) microseconds * 1000;
            Console.Write($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
