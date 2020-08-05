﻿using System;
using System.Runtime.CompilerServices;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int peoplePerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hours = 0;
            while (peopleCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                peopleCount -= peoplePerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
