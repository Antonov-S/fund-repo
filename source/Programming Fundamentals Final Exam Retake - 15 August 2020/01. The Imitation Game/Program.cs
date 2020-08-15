using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputString);

            while (command != "Decode")
            {
                string[] splited = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string currendCommand = splited[0];

                if (currendCommand == "Move")
                {
                    int numOfLettersToMove = int.Parse(splited[1]);
                    inputString = sb.ToString();

                    string temp = inputString.Substring(0, numOfLettersToMove);
                    sb = sb.Remove(0, numOfLettersToMove);
                    sb = sb.Append(temp);
                    // Console.WriteLine(sb);

                }
                else if (currendCommand == "Insert")
                {
                    int numOfIndex = int.Parse(splited[1]);
                    string value = splited[2];
                    sb = sb.Insert(numOfIndex, value);
                    // Console.WriteLine(sb);
                }
                else if (currendCommand == "ChangeAll")
                {
                    string currentSubstring = splited[1];
                    string newSubstring = splited[2];
                    sb = sb.Replace(currentSubstring, newSubstring);
                    // Console.WriteLine(sb);

                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {sb}");
        }
    }
}
