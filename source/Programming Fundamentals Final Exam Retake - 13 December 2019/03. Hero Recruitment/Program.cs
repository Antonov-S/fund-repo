using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> heros = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string currentHeroName = tokens[1];
                if (command == "Enroll")
                {

                    if (heros.ContainsKey(currentHeroName))
                    {
                        Console.WriteLine($"{currentHeroName} is already enrolled.");
                    }
                    else
                    {
                        heros[currentHeroName] = new List<string>();
                    }
                }
                else if (command == "Learn")
                {
                    string spell = tokens[2];
                    if (!heros.ContainsKey(currentHeroName))
                    {
                        Console.WriteLine($"{currentHeroName} doesn't exist.");
                    }
                    else if (heros[currentHeroName].Contains(spell))
                    {
                        Console.WriteLine($"{currentHeroName} has already learnt {spell}.");
                    }
                    else
                    {
                        heros[currentHeroName].Add(spell);

                    }
                }
                else if (command == "Unlearn")
                {
                    string spell = tokens[2];
                    if (!heros.ContainsKey(currentHeroName))
                    {
                        Console.WriteLine($"{currentHeroName} doesn't exist.");
                    }
                    else if (!heros[currentHeroName].Contains(spell))
                    {
                        Console.WriteLine($"{currentHeroName} doesn't know {spell}.");
                    }
                    else
                    {
                        heros[currentHeroName].Remove(spell);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Heroes:");
            foreach (var item in heros.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.Write($"== {item.Key}:");

                int count = 0;
                foreach (var kvp in item.Value)
                {
                    count++;
                    if (count == item.Value.Count)
                    {
                        Console.Write($" {kvp}");
                    }
                    else
                    {
                        Console.Write($" {kvp},");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
