namespace TheaThePhotographer
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            long pictures = long.Parse(Console.ReadLine());
            long secondsPerPicture = long.Parse(Console.ReadLine());
            long filterPercent = long.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());
            long filterSeconds = pictures * secondsPerPicture;
            long filteredPics = (long)Math.Ceiling(filterPercent * pictures / 100.0);
            long uploadSeconds = filteredPics * uploadTimePerPicture;
            long totalSeconds = filterSeconds + uploadSeconds;
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);
        }
    }
}
