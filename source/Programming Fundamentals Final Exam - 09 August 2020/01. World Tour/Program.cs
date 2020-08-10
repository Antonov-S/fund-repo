using System;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string plannedStops = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] splited = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Add Stop"))
                {
                    int index = int.Parse(splited[1]);
                    string newString = splited[2];

                    if (index >= 0 && index <= plannedStops.Length -1)
                    {
                        plannedStops = plannedStops.Insert(index, newString);
                    }
                    Console.WriteLine(plannedStops);
                }
                if (command.Contains("Remove Stop"))
                {
                    int startIndex = int.Parse(splited[1]);
                    int endIndex = int.Parse(splited[2]);
                    int lenght = endIndex - startIndex + 1;
                    

                    if ((startIndex >= 0 && startIndex <= plannedStops.Length -1) && (endIndex >= 0 && endIndex <= plannedStops.Length - 1))
                    {
                        plannedStops = plannedStops.Remove(startIndex, lenght);
                    }
                    Console.WriteLine(plannedStops);
                }
                if (command.Contains("Switch"))
                {
                    string oldSubstring = splited[1];
                    string newSubstring = splited[2];
                    StringBuilder sb = new StringBuilder();
                    sb.Append(plannedStops);
                    sb.Replace(oldSubstring, newSubstring);
                    plannedStops = sb.ToString();

                    
                    
                    Console.WriteLine(plannedStops);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {plannedStops}");
        }
    }
}
