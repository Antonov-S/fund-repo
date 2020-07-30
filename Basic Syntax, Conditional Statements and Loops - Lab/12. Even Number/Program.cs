using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            while (true)
            {
                if (input % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    break;
                }
                input = int.Parse(Console.ReadLine());

            }
        }
    }
}
