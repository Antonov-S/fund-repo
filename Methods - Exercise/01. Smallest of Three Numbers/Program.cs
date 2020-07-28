using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                inputs.Add(input);
            }
                
            Environment.NewLine

            int smallestNum = GetSmallestOfThreeNum(inputs);
            Console.WriteLine(smallestNum);
        }

        static int GetSmallestOfThreeNum (List<int> inputs)
        {
            return inputs.Min(); 
        }
    }
}
