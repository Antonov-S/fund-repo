using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper_Problem_Description
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=]|[/]{1})([A-Z][a-zA-Z]{3,})\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> validLocations = new List<string>();

            foreach (Match match in matches)
            {
                validLocations.Add(match.Groups[2].Value);
            }

            int travelPoints = 0;
            for (int i = 0; i < validLocations.Count; i++)
            {
                
                    travelPoints += validLocations[i].Length;                
            }

            Console.WriteLine($"Destinations: {String.Join(", ", validLocations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");

            
        }
    }
}
