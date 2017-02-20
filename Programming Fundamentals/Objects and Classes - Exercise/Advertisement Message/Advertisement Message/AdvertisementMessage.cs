using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            var adPhase = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            var adEvent = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var adAuthor = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            var adCity = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var random = new Random();

            Console.WriteLine("{0} {1} {2} - {3} ",
                adPhase[random.Next(0, adPhase.Count)],
                adEvent[random.Next(0, adEvent.Count)],
                adAuthor[random.Next(0, adAuthor.Count)],
                adCity[random.Next(0, adCity.Count)]);
        }
    }
}
