using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int division = 0;

            if (inputNum % 10 == 0)
            {
                division = 10;
            }
            else if (inputNum % 7 == 0)
            {
                division = 7;
            }
            else if (inputNum % 6 == 0)
            {
                division = 6;
            }
            else if (inputNum % 3 == 0)
            {
                division = 3;
            }
            else if (inputNum % 2 == 0)
            {
                division = 2;
            }
            else
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {division}");



        }
    }
}

