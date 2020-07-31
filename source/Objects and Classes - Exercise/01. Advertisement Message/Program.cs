using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(AdvertisementMessage.GenerateMessage());
            }
        }

        public class AdvertisementMessage
        {
            public static string[] phrases = {"Excellent product.", "Such a great product.", 
                "I always use that product.", "Best product of its category.", 
                "Exceptional product.", "I can’t live without this product."};

            public static string[] events = { "Now I feel good.", "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", "I feel great!" };

            public static string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie",
                "Eva" };

            public static string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public static string GenerateMessage()
            {
                Random rand = new Random();
                string currentPhrase = phrases[rand.Next(0, phrases.Length - 1)];
                string currentEvent = events[rand.Next(0, events.Length - 1)];
                string currentAutor = autors[rand.Next(0, events.Length - 1)];
                string currentCities = cities[rand.Next(0, cities.Length - 1)];

                return $"{currentPhrase} {currentEvent} {currentAutor} – {currentCities}.";
            }

        }
    }
}
