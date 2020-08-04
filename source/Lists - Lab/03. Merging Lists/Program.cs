using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
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
            List<int> firstList = ReadIntListSingleLine();
            List<int> secondList = ReadIntListSingleLine();
            Console.WriteLine(String.Join(" ", MergeTwolists(firstList, secondList))); 
        }

        static List<int> MergeTwolists(List<int> first, List<int> second)
        {
            int count = Math.Max(first.Count, second.Count);
            List<int> mergedList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (first.Count > i)
                {
                    mergedList.Add(first[i]);
                }

                if (second.Count > i)
                {
                    mergedList.Add(second[i]);
                }
            }
            return mergedList;
        }

    }
}
