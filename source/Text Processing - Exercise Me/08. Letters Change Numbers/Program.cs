using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double result = 0.0;

            for (int i = 0; i < input.Length; i++)
            {
                string text = input[i];
                char letterBefore = text[0];
                char letterAfter = text[text.Length - 1];
                double number = double.Parse(text.Substring(1, text.Length - 2));

                int letterBeforePosition = char.Parse(letterBefore.ToString()
                    .ToUpper()) - 64;
                int letterAfterPosition = char.Parse(letterAfter.ToString()
                    .ToUpper()) - 64;

                if (letterBefore >= 65 && letterBefore <= 90)
                {
                    number /= letterBeforePosition;
                }
                else
                {
                    number *= letterBeforePosition;
                }

                if (letterAfter >= 65 && letterAfter <= 90)
                {
                    number -= letterAfterPosition;
                }
                else
                {
                    number += letterAfterPosition;
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
