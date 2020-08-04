using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestGoingToParty = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string currentName = command[0];

                if (command.Length == 3)
                {
                    if (guestGoingToParty.Contains(currentName))
                    {
                        Console.WriteLine($"{currentName} is already in the list!");
                    }
                    else
                    {
                        guestGoingToParty.Add(currentName);
                    }
                }
                else
                {
                    if (guestGoingToParty.Contains(currentName))
                    {
                        guestGoingToParty.Remove(currentName);

                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, guestGoingToParty));
        }
    }
}
