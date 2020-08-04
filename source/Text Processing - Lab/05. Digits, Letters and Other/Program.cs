using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.IsDigit(inputText[i]))
                {
                    digits.Append(inputText[i]);
                }
                else if (char.IsLetter(inputText[i]))
                {
                    letters.Append(inputText[i]);
                }
                else
                {
                    others.Append(inputText[i]);
                }
                
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
