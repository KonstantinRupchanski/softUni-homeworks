﻿using System;

namespace AdvertisementMessage
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product."
                , "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[rand.Next(0, phrases.Length - 1)]} {events[rand.Next(0, events.Length - 1)]} {authors[rand.Next(0, events.Length - 1)]} - {cities[rand.Next(0, cities.Length - 1)]}");
            }
        }
    }
}
