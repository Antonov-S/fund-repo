using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jurnal = Console.ReadLine().Split(", ").ToList();

            string token = String.Empty;

            while ((token = Console.ReadLine()) != "Craft!")
            {
                string[] fullCommand = token.Split(" - ");
                string command = fullCommand[0];
                

                if (command == "Collect")
                {
                    string item = fullCommand[1];
                    if (!jurnal.Contains(item))
                    {
                        jurnal.Add(item);
                    }
                    
                }
                else if (command == "Drop")
                {
                    string item = fullCommand[1];
                    if (jurnal.Contains(item))
                    {
                        jurnal.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] items = fullCommand[1].Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (jurnal.Contains(oldItem))
                    {
                        int indexOldItem = jurnal.IndexOf(oldItem);
                        jurnal.Insert(indexOldItem + 1, newItem);
                    }

                }
                else if (command == "Renew")
                {
                    string item = fullCommand[1];
                    if (jurnal.Contains(item))
                    {
                        jurnal.Remove(item);
                        jurnal.Add(item);
                    }

                }

            }

            Console.WriteLine(String.Join(", ", jurnal));
        }
    }
}
