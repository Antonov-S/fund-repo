using System;
using System.Globalization;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            byte monthsNeeded = byte.Parse(Console.ReadLine());

            double totalSavings = 0.0;
            

            for (int i = 0; i <= monthsNeeded; i++)
            {
                if (i % 2 != 0 && i != 0)
                {
                    totalSavings *= 0.84;
                }
                else if (i % 4 == 0)
                {
                    totalSavings *= 1.25;
                }

                totalSavings += journeyCost * 0.25;
         
            }

            if (totalSavings >= journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(totalSavings - journeyCost):F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(journeyCost - totalSavings):F2}lv. more.");
            }
        }
    }
}
