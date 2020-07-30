using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrade = double.Parse(Console.ReadLine());

            if (studentGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
