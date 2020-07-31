using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string cours = tokens[0];
                string student = tokens[1];

                if (courses.ContainsKey(cours))
                {
                    courses[cours].Add(student);
                }
                else
                {
                    courses.Add(cours, new List<string>());
                    courses[cours].Add(student);
                }
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value.Count);
                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}", item);
                }
            }
        }
    }
}
