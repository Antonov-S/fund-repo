using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split("|").ToArray();

            int initialHealth = 100;
            int initialBitcoin = 0;
            

            for (int i = 0; i < inputData.Length; i++)
            {
                string[] tokens = inputData[i].Split();
                string command = tokens[0];
                int num = int.Parse(tokens[1]);

                if (command == "potion")
                {
                    int value = 0;

                    if (initialHealth + num < 100)
                    {
                        value = num;
                        initialHealth += value;
                        
                    }
                    else
                    {
                        value = 100 - initialHealth;
                        initialHealth += value;
                    }
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if(command == "chest")
                {
                    int foundBitcoins = num;
                    initialBitcoin += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");
                }
                else
                {
                    string monster = command;

                    if (initialHealth - num > 0)
                    {
                        initialHealth -= num;
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        initialHealth -= num;
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }

            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoin}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }


    }
}
