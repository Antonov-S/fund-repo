using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var regex = new Regex(@"[|](?<name>[A-Z]+)[|]:[#](?<title>[A-Za-z]+ [A-Za-z]+)[#]");
                var match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string title = match.Groups["title"].Value;

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
