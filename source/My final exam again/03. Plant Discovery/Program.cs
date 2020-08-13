using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Plant
    {
        public int Rarity { get; set; }
        public double Rating { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                string[] tokens = input.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string curentPlantName = tokens[0];
                int rarity = int.Parse(tokens[1]);
                Plant plant = new Plant() { Rarity = rarity, Rating = 0.0 };

                if (plants.ContainsKey(curentPlantName))
                {
                    plants[curentPlantName].Rarity = rarity;
                }
                else
                {
                    plants.Add(curentPlantName, plant);
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] splitted = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = splitted[0];
                string plantName = splitted[1];

                if (operation == "Rate")
                {
                    double rating = double.Parse(splitted[2]);
                    if (plants[plantName].Rating == 0)
                    {
                        plants[plantName].Rating = rating;
                    }
                    else
                    {
                        plants[plantName].Rating = (plants[plantName].Rating + rating) / 2;
                    }
                }
                else if (operation == "Update")
                {
                    int rarity = int.Parse(splitted[2]);
                    plants[plantName].Rarity = rarity;
                }
                else if (operation == "Reset")
                {
                    plants[plantName].Rating = 0.0;
                }
                else
                {
                    Console.WriteLine("error");
                    command = Console.ReadLine();
                    continue;
                    

                }
                
                command = Console.ReadLine();
            }

            Dictionary<string, Plant> sorted = new Dictionary<string, Plant>();
            sorted = plants.OrderByDescending(x => x.Value.Rarity)
                .ThenByDescending(x => x.Value.Rating)
                .ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var pair in sorted)
            {
                Console.WriteLine($"- {pair.Key}; Rarity: {pair.Value.Rarity}; Rating: {pair.Value.Rating:f2}");
            }


        }
    }
}
