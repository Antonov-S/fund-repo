using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                string studentName = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(currentGrade);
                }
                else
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(currentGrade);
                }
            }

            foreach (var eachStudent in students.OrderByDescending(x => x.Value.Average()))
            {

                if (eachStudent.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{eachStudent.Key} -> {eachStudent.Value.Average():f2}");
                }
            }
        }
    }
}
