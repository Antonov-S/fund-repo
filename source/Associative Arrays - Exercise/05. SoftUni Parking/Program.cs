using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLog = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split().ToArray();
                string name = tokens[1];
                

                if (tokens[0] == "register")
                {
                    string plateNumber = tokens[2];
                    if (parkingLog.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingLog[name]}");
                        continue;
                    }
                    else
                    {
                        parkingLog.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                }
                else if (tokens[0] == "unregister")
                {
                    if (parkingLog.ContainsKey(name))
                    {
                        parkingLog.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                        continue;
                    }
                    else
                    {
                        
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }

                }
            }

            foreach (var pair in parkingLog)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
