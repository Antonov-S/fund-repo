using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                if (command.Contains("Contains"))
                {
                    string[] splitted = command.Split(">>>");
                    string neededSubstring = splitted[1];

                    if (input.Contains(neededSubstring))
                    {
                        Console.WriteLine($"{input} contains {neededSubstring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (command.Contains("Flip"))
                {
                    string[] splitted = command.Split(">>>");
                    string method = splitted[1];
                    int startIndex = int.Parse(splitted[2]);
                    int lenght = int.Parse(splitted[3]) - startIndex;
                    
                    string oldSubstring = input.Substring(startIndex, lenght);
                    string newSubstring = string.Empty;
                    if (method == "Upper")
                    {
                        
                        newSubstring = oldSubstring.ToUpper();
                    }
                    else
                    {
                        newSubstring = oldSubstring.ToLower();
                    }
                    input = input.Replace(oldSubstring, newSubstring);
                    Console.WriteLine(input);
                    
                }

                if (command.Contains("Slice"))
                {
                    string[] splitted = command.Split(">>>");
                    
                    int startIndex = int.Parse(splitted[1]);
                    int length = int.Parse(splitted[2]) - startIndex;
                    
                    input = input.Remove(startIndex, length);
                    
                    Console.WriteLine(input);

                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
