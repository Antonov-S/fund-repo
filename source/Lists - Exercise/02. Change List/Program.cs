using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();

                if (elements[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        int elementToDelete = int.Parse(elements[1]);

                        if (elementToDelete == list[i])
                        {
                            list.Remove(list[i]);
                            i--;
                        }

                    }
                }
                else if (elements[0] == "Insert")
                {
                    int elementToInsert = int.Parse(elements[1]);
                    int indexToInsert = int.Parse(elements[2]);
                    list.Insert(indexToInsert, elementToInsert);
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }

    }
}
