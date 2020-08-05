using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort countStudents = ushort.Parse(Console.ReadLine());
            ushort countLectures = ushort.Parse(Console.ReadLine());
            ushort initialBonus  = ushort.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendances = 0;

            for (int i = 0; i < countStudents; i++)
            {
                int currentAttendances = int.Parse(Console.ReadLine());

                // {total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
                double currentBonus = currentAttendances * 1.0 / countLectures * (5 + initialBonus);

                // "Max Bonus: {maxBonusPoints}."
                // "The student has attended {studentAttendances} lectures."

                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendances = currentAttendances;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");

        }
    }
}
