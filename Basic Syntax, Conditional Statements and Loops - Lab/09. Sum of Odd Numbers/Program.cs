﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < numberInput * 2; i++)
            {
                if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }
                
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
