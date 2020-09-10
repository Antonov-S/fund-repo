using System;

namespace _05._Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceSinger = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double price = 0;
            int gestsCounter = 0;
            double totalMoney = 0.0;

            while (command != "The restaurant is full")
            {
                int peopleInGrup = int.Parse(command);

                if (peopleInGrup < 5)
                {
                    price = 100;
                }
                else
                {
                    price = 70;
                }

                double money = peopleInGrup * price;
                gestsCounter += peopleInGrup;
                totalMoney += money;

                command = Console.ReadLine();
            }

            if (totalMoney >= priceSinger)
            {
                Console.WriteLine($"You have {gestsCounter} guests and {(totalMoney - priceSinger):F0} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {gestsCounter} guests and {totalMoney:F0} leva income, but no singer.");
            }
        }
    }
}
