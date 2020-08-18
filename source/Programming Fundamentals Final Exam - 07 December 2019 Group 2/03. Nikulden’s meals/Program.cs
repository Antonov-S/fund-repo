using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            byte unlikedMealsCounter = 0;

            while (input != "Stop")
            {
                string[] splited = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string command = splited[0];
                string guestName = splited[1];
                string mealName = splited[2];

                if (command == "Like")
                {
                    if (!guests.ContainsKey(guestName))
                    {
                        guests.Add(guestName, new List<string>() { mealName });
                    }
                    else if (!guests[guestName].Contains(mealName))
                    {
                        guests[guestName].Add(mealName);
                    }
                    
                }
                else if (command == "Unlike")
                {
                    if (!guests.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                    else if (!guests[guestName].Contains(mealName))
                    {
                        Console.WriteLine($"{guestName} doesn't have the {mealName} in his/her collection.");
                    }
                    else
                    {
                        guests[guestName].Remove(mealName);
                        unlikedMealsCounter++;
                        Console.WriteLine($"{guestName} doesn't like the {mealName}.");
                    }
                }

                
                input = Console.ReadLine();
            }

            foreach (var kvp in guests.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {unlikedMealsCounter}");
        }
    }
}
