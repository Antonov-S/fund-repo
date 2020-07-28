using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isBetween6And10 = CheckIfConteinBetweenSixAndTenSimbols(input);

            if (!isBetween6And10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool isConteinOnlyNumAndDigits = CheckIfConteinOnlyNumsAndLetters(input);

            if (!isConteinOnlyNumAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool isConteinAtLeastTwoDigits = CheckIfConteinAtLeatsTwoDigits(input);

            if (!isConteinAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            bool passwordValid = false;
            if (isBetween6And10 && isConteinOnlyNumAndDigits && isConteinAtLeastTwoDigits)
            {
                passwordValid = true;
            }

            if (passwordValid)
            {
                Console.WriteLine("Password is valid");
            }


        }

        static bool CheckIfConteinBetweenSixAndTenSimbols (string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIfConteinOnlyNumsAndLetters (string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char currentSimbol = input[i];

                if (!((currentSimbol >= 48 && currentSimbol <= 57) || (currentSimbol >= 65 && currentSimbol <= 90) || (currentSimbol >= 97 && currentSimbol <= 122)))
                {
                    return false;
                }
                

                
            }

            return true;
        }

        static bool CheckIfConteinAtLeatsTwoDigits (string input)
        {
            int conteinDigits = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    conteinDigits++;
                }
            }

            if (conteinDigits >= 2)
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
