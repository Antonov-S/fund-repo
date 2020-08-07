using System;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToList();
            

            for (int i = 0; i < inputString.Count - 1; i++)
            {
                char currentChar = inputString[i];
                char nextChar = inputString[i + 1];

                if (currentChar == nextChar)
                {
                    inputString.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(String.Join("", inputString));
        }
    }
}
