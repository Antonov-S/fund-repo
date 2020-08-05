using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Urgent")
                {
                    string item = tokens[1];
                    if (shoppingList.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    string item = tokens[1];
                    shoppingList.Remove(item);
                }
                else if (command == "Correct")
                {
                    string oldItem = tokens[1];
                    string newItem = tokens[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        int index = shoppingList.IndexOf(oldItem);
                        shoppingList[index] = newItem;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Rearrange")
                {
                    string item = tokens[1];
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                }
            }

            Console.WriteLine(String.Join(", ", shoppingList));
        }
    }
}
