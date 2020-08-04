using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] elements = command.Split();

                switch (elements[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(elements[1]);
                        inputList.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);

                        if (indexToInsert >= 0 && indexToInsert < inputList.Count)
                        {
                            inputList.Insert(indexToInsert, numberToInsert);
                              
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(elements[1]);
                        if (indexToRemove >= 0 && indexToRemove < inputList.Count)
                        {
                            inputList.RemoveAt(indexToRemove);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(elements[2]);
                        if (elements[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstNum = inputList[0];
                                inputList.Add(firstNum);
                                inputList.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastNum = inputList[inputList.Count - 1];
                                inputList.Insert(0, lastNum);
                                inputList.RemoveAt(inputList.Count - 1);
                            }
                        }
                        break;
                    
                }
            }

            Console.WriteLine(String.Join(" ", inputList));
        }
    }
}
