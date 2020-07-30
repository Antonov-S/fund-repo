using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dataString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
