using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            string input = string.Empty;
            short totalLenght = 0;
            short counter = 0;
            

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                short lenght = short.Parse(command[1]);
                totalLenght += lenght;
                if (totalLenght > array.Length - 1)
                {
                    totalLenght = 0;
                }
                if (array[totalLenght] == 0)
                {
                    Console.WriteLine($"Place {totalLenght} already had Valentine's day.");
                    continue;
                }

                array[totalLenght] -= 2;
                
                if (array[totalLenght] == 0)
                {
                    counter++;
                    Console.WriteLine($"Place {totalLenght} has Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {totalLenght}.");

            if (counter == array.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            if (counter != array.Length)
            {
                Console.WriteLine($"Cupid has failed {array.Length - counter} places.");
            }
        }
    }
}