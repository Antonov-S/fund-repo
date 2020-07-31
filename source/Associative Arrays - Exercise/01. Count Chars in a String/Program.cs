using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (currentSymbol == ' ')
                {
                    continue;
                }

                if (chars.ContainsKey(currentSymbol))
                {
                    chars[currentSymbol]++;
                }
                else
                {
                    chars.Add(currentSymbol, 1);
                }
            }

            foreach (var pair in chars)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
