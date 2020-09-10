using System;

namespace _01._Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyFood = double.Parse(Console.ReadLine());
            double moneySouvenirs = double.Parse(Console.ReadLine());
            double moneyHotel = double.Parse(Console.ReadLine());

            double distance = 2 * 210;

            double needGas = (distance / 100) * 7;
            double moneyGas = needGas * 1.85;

            double hotelFirstDay = moneyHotel * 0.9;
            double hotelSecondDay = moneyHotel * 0.85;
            double hotelThirdDay = moneyHotel * 0.8;

            

            double total = (3 * moneyFood) + (3 * moneySouvenirs) + hotelFirstDay + hotelSecondDay + hotelThirdDay + moneyGas;
            Console.WriteLine($"Money needed: {total:F2}");

        }
    }
}
