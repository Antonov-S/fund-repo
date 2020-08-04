using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
            List<int> startingNumbersList = numbers;

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "end")
                {
                    break;
                }

                string[] tokens = commandLine.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Contains":
                        int numberToCheck = int.Parse(tokens[1]);
                        bool itsContains = numbers.Contains(numberToCheck);
                        if (itsContains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ", Environment.NewLine);
                                
                            }
                        }
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                Console.Write(numbers[i] + " ", Environment.NewLine);
                                
                            }
                        }
                        break;
                    case "GetSum":
                        int sumOfnumbers = numbers.Sum();
                        Console.WriteLine(sumOfnumbers);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numberToFilter = int.Parse(tokens[2]);
                        switch (condition)
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < numberToFilter)
                                    {
                                        Console.Write(numbers[i] + " ", Environment.NewLine);
                                        
                                    }
                                }
                                break;
                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > numberToFilter)
                                    {
                                        Console.Write(numbers[i] + " ", Environment.NewLine);
                                        
                                    }
                                }
                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= numberToFilter)
                                    {
                                        Console.Write(numbers[i] + " ", Environment.NewLine);
                                        
                                    }
                                }
                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= numberToFilter)
                                    {
                                        Console.Write(numbers[i] + " ", Environment.NewLine);
                                        
                                    }
                                }
                                break;
                        }
                        break;
                }
            }

            if (startingNumbersList != numbers)
            {
                PrintListSeparetedBySpace(numbers);
            }
            
            

        }

        static void PrintListSeparetedBySpace(List<int> numbers)
        {
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

