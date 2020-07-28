using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum1 = int.Parse(Console.ReadLine());
            int inputNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Factorial_WhileLoopAndDivisionResults(inputNum1, inputNum2):F2}");
        }

        public static double Factorial_WhileLoopAndDivisionResults(int number1, int number2)
        {
            double result1 = 1;
            while (number1 != 1)
            {
                result1 = result1 * number1;
                number1 = number1 - 1;
            }

            double result2 = 1;
            while (number2 != 1)
            {
                result2 = result2 * number2;
                number2 = number2 - 1;
            }

            double finalResult = result1 / result2;
            return finalResult;
        }
    }
}
