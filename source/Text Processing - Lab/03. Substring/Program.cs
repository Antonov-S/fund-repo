using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            int startIndex = text.IndexOf(word);

            while (startIndex >= 0)
            {
                text = text.Remove(startIndex, word.Length);
                startIndex = text.IndexOf(word);
            }

            Console.WriteLine(text);
        }
    }
}
