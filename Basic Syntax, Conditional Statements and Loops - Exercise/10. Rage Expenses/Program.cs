using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            short lostGames = short.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double monitorPrice = double.Parse(Console.ReadLine());

            double expensesSum = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    expensesSum += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    expensesSum += mousePrice;
                }

                if (i % 6 == 0)
                {
                    expensesSum += keyboardPrice;
                }

                if (i % 12 == 0)
                {
                    expensesSum += monitorPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {expensesSum:F2} lv.");


        }
    }
}
