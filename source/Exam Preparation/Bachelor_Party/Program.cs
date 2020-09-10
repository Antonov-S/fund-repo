using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceSinger = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double totalMoney = 0.0;
            double priceForGrup = 0.0;
            int counterGests = 0;
            double moneyCurrentGrup = 0.0;

            while (true)
            {
                if (input == "The restaurant is full")
                {
                    break;
                }
                
                
                int countCurrentGrup = int.Parse(input);
                
                if (countCurrentGrup < 5)
                {
                    priceForGrup = 100.00;
                }
                else
                {
                    priceForGrup = 70.00;
                }

                moneyCurrentGrup = countCurrentGrup * priceForGrup;
                totalMoney += moneyCurrentGrup;
                counterGests += countCurrentGrup;

                input = Console.ReadLine();
            }

            if (totalMoney >= priceSinger)
            {
                Console.WriteLine($"You have {counterGests} guests and {(totalMoney - priceSinger):F0} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {counterGests} guests and {totalMoney:F0} leva income, but no singer.");
            }
        }
    }
}
