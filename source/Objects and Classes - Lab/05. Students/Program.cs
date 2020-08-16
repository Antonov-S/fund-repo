using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    SecondName = lastName,
                    Age = age,
                    Town = city
                };

                students.Add(student);
                line = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Town == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
                }
            }


        }

        public class Student
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
    }
}
