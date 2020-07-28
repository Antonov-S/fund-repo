using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                else
                {
                    int num = int.Parse(input);
                    bool isPalindrome = DecideIfNumIsPalindrome(num);
                    if (isPalindrome)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }


                input = Console.ReadLine();
            }
        }

        static bool DecideIfNumIsPalindrome (int num)
        {
            int n = num;
            int rev = 0;
            while (num > 0)
            {
                int dig = num % 10;
                rev = (rev * 10) + dig;
                num = num / 10;
            }
            
            if (n == rev)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
