using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"[!]([A-Z][a-z]{3,})[!]:[\[]([A-Za-z]{8,})[\]]");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string command = match.Groups[1].Value;
                    string message = match.Groups[2].Value;
                    Console.Write(command + ":" + " ");

                    foreach (var ch in message)
                    {
                        int result = ch;
                        Console.Write(result + " ");
                    }
                    Console.WriteLine();

                }

            }
            
        }
    }
}
