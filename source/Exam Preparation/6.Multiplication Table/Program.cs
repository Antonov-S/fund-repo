using System;

namespace _6.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsText = Console.ReadLine();

            string number3 = numberAsText[0].ToString();
            string number2 = numberAsText[1].ToString();
            string number1 = numberAsText[2].ToString();
            int digit3 = int.Parse(number3);
            int digit2 = int.Parse(number2);
            int digit1 = int.Parse(number1);



            for (int num1 = 1; num1 <= digit1; num1++)
            {
                for (int num2 = 1; num2 <= digit2; num2++)
                {
                    for (int num3 = 1; num3 <= digit3; num3++)
                    {
                        int result = num1 * num2 * num3;
                        Console.WriteLine($"{num1} * {num2} * {num3} = {result}");
                    }
                }
            }






        }
    }
}
