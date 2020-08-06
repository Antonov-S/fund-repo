using System;

namespace Programming_Fundamentals_Mid_Exam_Retake___07_April_2020
{
    class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            int distance = 0;
            string line = string.Empty;
            byte counter = 0;
            while ((line = Console.ReadLine()) != "End of battle")
            {
                distance = int.Parse(line);
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
                    return;
                }
                else
                {
                    energy -= distance;
                    counter++;
                }
                if (counter % 3 == 0)
                {
                    energy += counter;
                }

            }
            Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
        }
    }
}