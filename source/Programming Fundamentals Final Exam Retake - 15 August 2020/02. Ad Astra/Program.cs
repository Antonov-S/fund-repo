using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Food
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calorys { get; set; }

        public Food(string name, string date, int calorys)
        {
            this.Name = name;
            this.Date = date;
            this.Calorys = calorys;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var regex = new Regex(@"([#]|[|])([A-Za-z\s]+)\1([0-9][0-9]\/[0-9][0-9]\/[0-9][0-9])\1([0-9]+)\1");
            //var match = regex.Match(input);
            MatchCollection matches = regex.Matches(input);
            int sumCalorys = 0;
            List<Food> foods = new List<Food>();

            foreach (Match match in matches)
            {
                string name = match.Groups[2].Value;
                string date = match.Groups[3].Value;
                int calorys = int.Parse(match.Groups[4].Value);
                Food food = new Food(name, date, calorys);
                foods.Add(food);
            }

            foreach (var item in foods)
            {
                sumCalorys += item.Calorys;
            }

            int days = sumCalorys / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (var item in foods)
            {
                Console.WriteLine($"Item: {item.Name}, Best before: {item.Date}, Nutrition: {item.Calorys}");
            }
            
        }
    }
}
