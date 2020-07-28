using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetBigger(first, second));
            }
        }

        static int GetBigger(int first, int second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetBigger(char first, char second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetBigger(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
