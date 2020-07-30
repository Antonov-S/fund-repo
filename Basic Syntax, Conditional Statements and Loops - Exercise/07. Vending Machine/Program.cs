using System;
using System.Runtime.InteropServices;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalSum = 0;

            while (input != "Start")
            {
                double currentCoin = double.Parse(input);

                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
                {
                    totalSum += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                    currentCoin = 0;
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine().ToLower();

            while (input != "End")
            {
                if (input == "end")
                {
                    break;
                }

                double price = 0;
                switch (input)
                {
                    case "nuts": price = 2.0; break;
                    case "water": price = 0.7; break;
                    case "crisps": price = 1.5; break;
                    case "soda": price = 0.8; break;
                    case "coke": price = 1.0; break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }



                string purchasedProduct = string.Empty;
                
                if (price <= totalSum && price != 0)
                {
                    purchasedProduct = input;
                    totalSum -= price;
                    Console.WriteLine($"Purchased {purchasedProduct}");
                }
                else
                {
                    if (purchasedProduct != "End" && price != 0 && price < totalSum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {totalSum:F2}");
        }
    }
}