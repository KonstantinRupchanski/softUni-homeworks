namespace ConvertSpeedUnits
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            float distanceInMeteres = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float timeInSeconds = ((hours * 60) + minutes) * 60 + seconds;
            float metersPerSecond = distanceInMeteres / timeInSeconds;
            float timeInHours = hours+ (minutes/60) + (seconds /3600);
            float distanceInKilometers = distanceInMeteres / 1000;
            float kilometersPerHour = distanceInKilometers / timeInHours;
            float distanceInMiles = distanceInMeteres / 1609;
            float milesPerHour = distanceInMiles / timeInHours;
            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
