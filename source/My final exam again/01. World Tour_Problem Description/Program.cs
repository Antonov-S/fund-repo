using System;
using System.Text;

namespace _01._World_Tour_Problem_Description
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStops = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] tokens = command.Split(":");
                if (command.Contains("Add Stop"))
                {
                    int index = int.Parse(tokens[1]);
                    string newStringToAdd = tokens[2];

                    if (index >= 0 && index <= inputStops.Length - 1)
                    {
                        inputStops.Insert(index, newStringToAdd);
                        Console.WriteLine(inputStops);
                    }
                }

                if (command.Contains("Remove Stop"))
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if ((startIndex >= 0 && startIndex <= inputStops.Length - 1) && (endIndex >= 0 && endIndex <= inputStops.Length - 1))
                    {
                        inputStops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(inputStops);

                }

                if (command.Contains("Switch"))
                {
                    string oldString = tokens[1];
                    string newString = tokens[2];

                    StringBuilder sb = new StringBuilder();
                    sb.Append(inputStops);
                    sb.Replace(oldString, newString);
                    inputStops = sb.ToString();
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {inputStops}");
        }
    }
}
