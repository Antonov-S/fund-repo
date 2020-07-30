using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string passWord = String.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                passWord += userName[i];
            }

            string input = Console.ReadLine();
            int logginAttemps = 0;

            while (passWord != input)
            {
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                logginAttemps++;

                if (logginAttemps >= 3)
                {
                    Console.WriteLine($"User {userName} blocked! ");
                    break;
                }
            }

            if (input == passWord)
            {
                Console.WriteLine($"User {userName} logged in. ");
            }
        }
    }
}
