using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks.Dataflow;
using System.Reflection.Emit;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    class Program
    {
        public class Plant
        {
            public byte Rarity { get; set; }

            public double Rating { get; set; }
        }

        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Dictionary<string, Plant> plantDic = new Dictionary<string, Plant>();
            for (byte i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plantName = input[0];
                byte rarity = byte.Parse(input[1]);
                Plant plant = new Plant() { Rarity = rarity, Rating = 0 };

                if (plantDic.ContainsKey(input[0]))
                {
                    plantDic[plantName] = plant;
                }
                else
                {
                    plantDic.Add(plantName, plant);
                }
            }
            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                if (command.Contains("Rate:"))
                {
                    string[] splitted = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    var plantName = splitted[1];
                    var plantRating = double.Parse(splitted[2]);
                    if (plantDic.ContainsKey(plantName))
                    {
                        if (plantDic[plantName].Rating == 0)
                        {
                            plantDic[plantName].Rating = plantRating;
                        }
                        else
                        {
                            plantDic[plantName].Rating = (plantDic[plantName].Rating + plantRating) / 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command.Contains("Update:"))
                {
                    string[] splitted = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    var plantName = splitted[1];
                    byte newPlantRarity = byte.Parse(splitted[2]);
                    if (plantDic.ContainsKey(plantName))
                    {
                        plantDic[plantName].Rarity = newPlantRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command.Contains("Reset:"))
                {
                    string[] splitted = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    var plantName = splitted[1];

                    if (plantDic.ContainsKey(plantName))
                    {
                        plantDic[plantName].Rating = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                command = Console.ReadLine();
            }

            plantDic = plantDic.OrderByDescending(x => x.Value.Rarity)
                               .ThenByDescending(x => x.Value.Rating)
                               .ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var pair in plantDic)
            {
                Console.WriteLine($"- {pair.Key}; Rarity: {pair.Value.Rarity}; Rating: {pair.Value.Rating:f2}");
            }
        }
    }
}
