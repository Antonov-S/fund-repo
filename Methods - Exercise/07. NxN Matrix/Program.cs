using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            PrintsNxNmatrixOfNum(inputNum);

            
        }

        static void PrintsNxNmatrixOfNum (int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
