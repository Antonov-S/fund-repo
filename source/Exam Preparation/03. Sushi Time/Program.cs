using System;

namespace _03._Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeShushi = Console.ReadLine();
            string nameRestorant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();

            double price = 0.0;

            switch (nameRestorant)
            {
                case ("Sushi Zone"): 
                    if (typeShushi == "sashimi")
                    {
                        price = 4.99;
                    }
                    else if (typeShushi == "maki")
                    {
                        price = 5.29;
                    }
                    else if (typeShushi == "uramaki")
                    {
                        price = 5.99;
                    }
                    else if (typeShushi == "temaki")
                    {
                        price = 4.29;
                    }
                    break;
                case ("Sushi Time"):
                    if (typeShushi == "sashimi")
                    {
                        price = 5.49;
                    }
                    else if (typeShushi == "maki")
                    {
                        price = 4.69;
                    }
                    else if (typeShushi == "uramaki")
                    {
                        price = 4.49;
                    }
                    else if (typeShushi == "temaki")
                    {
                        price = 5.19;
                    }
                    break;
                case("Sushi Bar"):
                    if (typeShushi == "sashimi")
                    {
                        price = 5.25;
                    }
                    else if (typeShushi == "maki")
                    {
                        price = 5.55;
                    }
                    else if (typeShushi == "uramaki")
                    {
                        price = 6.25;
                    }
                    else if (typeShushi == "temaki")
                    {
                        price = 4.75;
                    }
                    break;
                case ("Asian Pub"):
                    if (typeShushi == "sashimi")
                    {
                        price = 4.50;
                    }
                    else if (typeShushi == "maki")
                    {
                        price = 4.80;
                    }
                    else if (typeShushi == "uramaki")
                    {
                        price = 5.50;
                    }
                    else if (typeShushi == "temaki")
                    {
                        price = 5.50;
                    }
                    break;

                default:
                    Console.WriteLine($"{nameRestorant} is  invalid  restaurant!");
                    break;
            }
            double total = price * portions;

            if (simbol == "Y")
            {
                total += Math.Ceiling(total * 0.20);
            }
            else
            {
                total = Math.Ceiling(total);
            }

            Console.WriteLine($"Total price: {total:F0} lv.");
        }
    }
}
