using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPassengers = int.Parse(Console.ReadLine());
            int countOfBusStations = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfBusStations; i++)
            {
                int countOutPasagers = int.Parse(Console.ReadLine());
                int countInPasagers = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    countOfPassengers = countOfPassengers + countInPasagers + 2 - countOutPasagers;
                }
                else
                {
                    countOfPassengers = countOfPassengers + countInPasagers - 2 - countOutPasagers;
                }
            }
            Console.WriteLine($"The final number of passengers is : {countOfPassengers}");
        }
    }
}