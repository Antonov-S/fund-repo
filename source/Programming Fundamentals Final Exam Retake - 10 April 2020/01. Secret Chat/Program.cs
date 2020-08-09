using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                var tokens = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "InsertSpace":
                        var index = int.Parse(tokens[1]);
                        concealedMessage = concealedMessage.Insert(index, " ");
                        Console.WriteLine(concealedMessage);
                        break;
                    case "Reverse":
                        var subString = tokens[1];
                        if (concealedMessage.Contains(subString))
                        {
                            concealedMessage = concealedMessage.Remove(concealedMessage.IndexOf(subString), subString.Length);
                            var reversed = new string(subString.Reverse().ToArray());
                            concealedMessage += reversed;
                            Console.WriteLine(concealedMessage);
                        }
                        else
                        {
                            Console.WriteLine("error");
                            input = Console.ReadLine();
                            continue;
                        }
                        break;
                    case "ChangeAll":
                        var substringToChange = tokens[1];
                        var replacement = tokens[2];
                        concealedMessage = concealedMessage.Replace(substringToChange, replacement);
                        Console.WriteLine(concealedMessage);
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
