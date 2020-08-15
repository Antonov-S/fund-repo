using System;
using System.Text;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputString);

            while (command != "Finish")
            {
                string[] splited = command.Split();
                string currentCommand = splited[0];
                if (currentCommand == "Replace")
                {
                    char currentChar = char.Parse(splited[1]);
                    char newChar = char.Parse(splited[2]);
                    sb = sb.Replace(currentChar, newChar);
                    Console.WriteLine(sb);
                }
                else if (currentCommand == "Cut")
                {
                    short startIndex = short.Parse(splited[1]);
                    short endIndex = short.Parse(splited[2]);
                    short lenght = (short)(endIndex - startIndex);
                    if (startIndex >= 0 && startIndex <= sb.Length && endIndex >= 0 && endIndex <= sb.Length)
                    {
                        sb.Remove(startIndex, lenght + 1);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (currentCommand == "Make")
                {
                    string subCommand = splited[1];
                    if (subCommand == "Upper")
                    {
                        string temp = sb.ToString();
                        temp = temp.ToUpper();
                        sb = sb.Clear();
                        sb.Append(temp);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        string temp = sb.ToString();
                        temp = temp.ToLower();
                        sb = sb.Clear();
                        sb.Append(temp);
                        Console.WriteLine(sb);
                    }
                }
                else if (currentCommand == "Check")
                {
                    string stringToFind = splited[1];
                    string temp = sb.ToString();
                    if (temp.Contains(stringToFind))
                    {
                        Console.WriteLine($"Message contains {stringToFind}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {stringToFind}");
                    }
                }
                else if (currentCommand == "Sum")
                {
                    short startIndex = short.Parse(splited[1]);
                    short endIndex = short.Parse(splited[2]);
                    short lenght = (short)(endIndex - startIndex);
                    if (startIndex >= 0 && startIndex <= sb.Length && endIndex >= 0 && endIndex <= sb.Length)
                    {
                        string temp = sb.ToString();
                        string substring = temp.Substring(startIndex, lenght + 1);
                        int sum = 0;
                        for (int i = 0; i < substring.Length; i++)
                        {
                            sum += substring[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    
                }
                



                command = Console.ReadLine();
            }
        }
    }
}
