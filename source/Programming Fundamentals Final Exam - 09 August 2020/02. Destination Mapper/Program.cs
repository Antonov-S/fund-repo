using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=]{1}|[/]{1})([A-Z][a-zA-Z]{3,})\1";
            // ([:]{2}|[*]{2})

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> validLocations = new List<string>();

            foreach (Match match in matches)
            {
                string currentValidLocation = match.Groups[2].Value;
                validLocations.Add(currentValidLocation);
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
