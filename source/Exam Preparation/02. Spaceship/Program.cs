using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthShip = double.Parse(Console.ReadLine());
            double lengthShip = double.Parse(Console.ReadLine());
            double heightShip = double.Parse(Console.ReadLine());
            double averageHeightCrew = double.Parse(Console.ReadLine());

            double areaShip = widthShip * lengthShip * heightShip;
            double areaCabin = (averageHeightCrew + 0.40) * 2 * 2;
            double maxCrewMembers = Math.Floor(areaShip / areaCabin);



            if (maxCrewMembers < 3)
            {
                Console.WriteLine("the spacecraft is too small.");
            }
            else if (maxCrewMembers >= 3 && maxCrewMembers <= 10)
            {
                Console.WriteLine($"the spacecraft holds {maxCrewMembers} astronauts.");
            }
            else if (maxCrewMembers > 10)
            {
                Console.WriteLine("the spacecraft is too big.");
            }






        }
    }
}
