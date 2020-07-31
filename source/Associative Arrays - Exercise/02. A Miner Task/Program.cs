using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> miners = new Dictionary<string, int>();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (miners.ContainsKey(input))
                {
                    miners[input] += quantity;
                }
                else
                {
                    miners.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in miners)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }

        }
    }
}
