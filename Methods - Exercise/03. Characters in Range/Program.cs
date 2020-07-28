using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            PrintCharactersInRange(startChar, endChar);
        }

        static void PrintCharactersInRange (char start, char end)
        {
            
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

            
        }
    }
}
