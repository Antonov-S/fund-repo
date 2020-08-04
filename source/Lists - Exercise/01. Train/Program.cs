using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagons = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elemensts = command.Split();

                if (elemensts[0] == "Add")
                {
                    int passengers = int.Parse(elemensts[1]);
                    passengersInWagons.Add(passengers);
                }
                else
                {
                    int newPassengers = int.Parse(elemensts[0]);

                    for (int i = 0; i < passengersInWagons.Count; i++)
                    {
                        if (passengersInWagons[i] + newPassengers <= maxCapacity)
                        {
                            passengersInWagons[i] += newPassengers;
                            break;
                        }
                    }
                }

                
            }
            Console.WriteLine(String.Join(" ", passengersInWagons));


        }
    }
}
