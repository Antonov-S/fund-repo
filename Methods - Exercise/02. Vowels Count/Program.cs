using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int count = CountAllVoweLsInOneString(input);
            Console.WriteLine(count);
        }

        static int CountAllVoweLsInOneString (string word)
        {
            int countVowels = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    countVowels++;
                }
            }

            return countVowels;
        }


    }
}
