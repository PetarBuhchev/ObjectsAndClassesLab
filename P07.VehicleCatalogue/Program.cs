using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static P07.VehicleCatalogue.Program;

namespace P07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/");
            Catalog catalog = new Catalog();
            catalog.Cars = new List<Car>();
            catalog.Trucks = new List<Truck>();
            while (input[0] != "end")
            {
                if (input[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = input[1];
                    car.Model = input[2];
                    car.HorsePower = int.Parse(input[3]);

                    catalog.Cars.Add(car);
                }
                else if (input[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = input[1];
                    truck.Model = input[2];
                    truck.Weight = int.Parse(input[3]);

                    catalog.Trucks.Add(truck);
                }
                input = Console.ReadLine().Split("/");
            }
            if (catalog.Cars.Count != 0)
            {
                catalog.Cars.Sort((x, y) => string.Compare(x.Brand, y.Brand));
                catalog.Cars.Sort((x, y) => string.Compare(x.Model, y.Model));
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                if (catalog.Trucks.Count != 0)
                {
                catalog.Trucks.Sort((x, y) => string.Compare(x.Brand, y.Brand));
                catalog.Trucks.Sort((x, y) => string.Compare(x.Model, y.Model));
                    Console.WriteLine("Trucks:");
                    foreach (Truck truck in catalog.Trucks)
                    {
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    }
                }
            }

        }
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        public class Catalog
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
