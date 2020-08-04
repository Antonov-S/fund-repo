using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            return list;
        }

        static void Main(string[] args)
        {
            List<int> numbers = ReadIntListSingleLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i--);
                }
            }

            numbers.Reverse();

            if (numbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));
            }

            
        }
    }
}
