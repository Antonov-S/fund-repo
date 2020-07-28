using System;
using System.IO;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string endString = RepeatStringNtimes(inputString, count);
            Console.WriteLine(endString);
        }

        static string RepeatStringNtimes(string str, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
