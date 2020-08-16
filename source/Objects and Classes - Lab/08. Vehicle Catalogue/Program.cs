using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _08._Vehicle_Catalogue
{
    // Truck with the following properties: Brand, Model and Weight.

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    // Car with the following properties: Brand, Model and Horse Power.
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    // Catalog with the following properties: Collections of Trucks and Cars.
    class CatalogueVehicle
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            string inputPrompt = Console.ReadLine();

            while (inputPrompt != "end")
            {
                string[] tokens = inputPrompt.Split("/");
                // Car/Maserati/Levante/350
                // Truck / Mercedes / Actros / 9019

                if (tokens.Contains("Car"))
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    int horsePower = int.Parse(tokens[3]);

                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    cars.Add(car);
                }

                if (tokens.Contains("Truck"))
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    int weight = int.Parse(tokens[3]);

                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    trucks.Add(truck);
                }
                inputPrompt = Console.ReadLine();
            }

            
            CatalogueVehicle catalogueVehicle = new CatalogueVehicle();
                       
            catalogueVehicle.Cars = cars;
            catalogueVehicle.Trucks = trucks;


            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogueVehicle.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogueVehicle.Trucks.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
                                
            

        }
    }
}
