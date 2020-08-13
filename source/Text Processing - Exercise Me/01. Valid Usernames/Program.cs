using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            var validUsernames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];

                if (currentWord.Length >= 3 && currentWord.Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(currentWord[j]) || currentWord[j] == '-' || currentWord[j] == '_'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(currentWord);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
    }
}
