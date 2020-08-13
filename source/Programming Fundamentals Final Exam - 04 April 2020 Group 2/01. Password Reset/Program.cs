using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.Split();

                if (command[0] == "TakeOdd")
                {
                    StringBuilder oddChars = new StringBuilder();
                    for (int i = 1; i < inputString.Length; i+=2)
                    {
                                               
                        oddChars.Append(inputString[i]);
                        
                    }
                    inputString = oddChars.ToString();
                    Console.WriteLine(inputString);
                }
                else if (command[0] == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    inputString = inputString.Remove(index, length);
                    Console.WriteLine(inputString);

                }
                else
                {
                    string oldSubstring = command[1];
                    string newSubstring = command[2];
                    if (inputString.IndexOf(oldSubstring) == -1)
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                    inputString = inputString.Replace(oldSubstring, newSubstring);
                    Console.WriteLine(inputString);
                }
            }

            Console.WriteLine($"Your password is: {inputString}");
        }
    }
}
