using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();
            
            Console.WriteLine(CharacterMultiplier(inputString[0], inputString[1]));

        }

        static public int CharacterMultiplier(string first, string second)
        {
                       
            int result = 0;
            string shortest = string.Empty;
            string longest = string.Empty;

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
                result += shortest[i] * longest[i];
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                result += longest[i];
            }
            return result;
        }
    }
}
