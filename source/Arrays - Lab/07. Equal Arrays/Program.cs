﻿using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            bool isEqual = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNum = arr1[i];
                if (arr1[i] != arr2[i])
                {
                    
                    Console.WriteLine($"Arrays are not identical. Found difference at {currentNum - 1} index");
                    return;
                }
                
                if (arr1[i] == arr2[i])
                {
                    isEqual = true;
                    sum += arr1[i];
                }
            }

            if (isEqual)
                { 
                    Console.WriteLine($"Arrays are identical. Sum: {sum}"); 
                }
        }
    }
}
