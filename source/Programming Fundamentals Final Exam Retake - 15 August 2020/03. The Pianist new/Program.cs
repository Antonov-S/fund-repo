using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist_new
{
    class Piece
    {
        public string Composer { get; set; }
        public string Kay { get; set; }
        public Piece(string composer, string kay)
        {
            this.Composer = composer;
            this.Kay = kay;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Piece> playbook = new Dictionary<string, Piece>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] splited = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = splited[0];
                string composer = splited[1];
                string key = splited[2];
                Piece piece = new Piece(composer, key);
                playbook.Add(name, piece);
            }

            string newInput = Console.ReadLine();
            while (newInput != "Stop")
            {
                string[] tokens = newInput.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                string currentPiece = tokens[1];

                if (currentCommand == "Add")
                {
                    string currentComposer = tokens[2];
                    string currentKay = tokens[3];

                    if (playbook.ContainsKey(currentPiece))
                    {
                        Console.WriteLine($"{currentPiece} is already in the collection!");
                    }
                    else
                    {
                        Piece piece = new Piece(currentComposer, currentKay);
                        playbook.Add(currentPiece, piece);
                        Console.WriteLine($"{currentPiece} by {currentComposer} in {currentKay} added to the collection!"
);
                    }
                }
                else if (currentCommand == "Remove")
                {
                    if (!playbook.ContainsKey(currentPiece))
                    {
                        Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
                    }
                    else
                    {
                        playbook.Remove(currentPiece);
                        Console.WriteLine($"Successfully removed {currentPiece}!");
                    }
                }
                else if (currentCommand == "ChangeKey")
                {
                    string newKey = tokens[2];
                    if (!playbook.ContainsKey(currentPiece))
                    {
                        Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
                    }
                    else
                    {
                        Console.WriteLine($"Changed the key of {currentPiece} to {newKey}!");
                        playbook[currentPiece].Kay = newKey;
                        
                    }
                }

                newInput = Console.ReadLine();
            }

            

            playbook = playbook.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer).ToDictionary(x => x.Key, y => y.Value);
            foreach (var pair in playbook)
            {
                Console.WriteLine($"{pair.Key} -> Composer: {pair.Value.Composer}, Key: {pair.Value.Kay}");
            }


        }
    }
}
