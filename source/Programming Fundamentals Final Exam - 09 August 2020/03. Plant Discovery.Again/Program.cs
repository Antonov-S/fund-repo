using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery.Again
{
    class Plant
    {
        public string Name { get; set; }
        public List<int> Rating { get; set; }
        public int Rarity { get; set; }

        public Plant(string name, List<int> rating, int raryty)
        {
            this.Name = name;
            this.Rating = rating;
            this.Rarity = raryty;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string inputPlant = Console.ReadLine();
                string[] splited = inputPlant.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string currentPlant = splited[0];
                int currentPlantRarity = int.Parse(splited[1]);

                if (plants.ContainsKey(currentPlant))
                {
                    plants[currentPlant].Rarity = currentPlantRarity;
                }
                else
                {
                    plants.Add(currentPlant, new Plant(currentPlant, new List<int>(), currentPlantRarity));
                }

            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Rate:")
                {
                    string plantName = tokens[1];
                    int rating = int.Parse(tokens[3]);
                    plants[plantName].Rating.Add(rating);
                }
                else if (tokens[0] == "Update")
                {
                    string plantName = tokens[1];
                    int newRarity = int.Parse(tokens[3]);
                    plants[plantName].Rarity = newRarity;
                }
                else if (tokens[0] == "Reset:")
                {
                    string plantName = tokens[1];
                    plants[plantName].Rating.Clear();
                }
                else
                {
                    Console.WriteLine("error");
                    command = Console.ReadLine();
                    continue;
                }
                
                command = Console.ReadLine();
            }

            //plants[plantName].Rating.Average();

            var sortedPlants = plants.OrderByDescending(h => h.Value.Rarity).ThenByDescending(h => h.Value.Rating.Average());
            

            //.ThenByDescending(h => h.Value.Rating.Average()

            Console.WriteLine("Plants for the exhibition:");
            foreach (var pair in sortedPlants)
            {
                Console.WriteLine($"- {pair.Key}; Rarity: {pair.Value.Rarity}; Rating: {pair.Value.Rating.Average():f2}");
            }
              


        }
    }
}
