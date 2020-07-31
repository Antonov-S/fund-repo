using System;
using System.Diagnostics.CodeAnalysis;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(CharMultiplaer(input[0], input[1]));
            
        }

        static int CharMultiplaer(string first, string second)
        {
            int sum = 0;
            string longest = String.Empty;
            string shortest = String.Empty;

            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                sum += shortest[i] * longest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }


            return sum;
        }
    }
}
