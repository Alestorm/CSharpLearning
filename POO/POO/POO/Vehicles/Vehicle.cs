using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Vehicles
{
    public class Vehicle
    {
        public int IdVehicle { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public double EngineSize { get; set; }
        public int HorsePower { get; set; }
        public double FuelCapacity { get; set; }
        public string FuelType { get; set; }
        public double Mileage { get; set; }
        public string Transmission { get; set; }
        public int NumberOfDoors { get; set; }
        public bool IsElectric { get; set; }
        public double MaxSpeed { get; set; }
        public string Plate { get; set; }
        public bool IsInsured { get; set; }

        public void DisplayVehicleInfo()
        {
            Console.WriteLine($"\n------------------Vehicle Information-------------------");
            Console.WriteLine($"ID: {IdVehicle}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"VIN: {VIN}");
            Console.WriteLine($"Engine Size: {EngineSize} liters");
            Console.WriteLine($"Horse Power: {HorsePower} hp");
            Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Mileage: {Mileage} km");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Is Electric: {(IsElectric ? "Yes" : "No")}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
            Console.WriteLine($"Plate: {Plate}");
            Console.WriteLine($"Is Insured: {(IsInsured ? "Yes" : "No")}");
            Console.WriteLine($"----------------------------------------------------------");
        }
        public void DisplayBrandAndModel()
        {
            Console.WriteLine($"\n------------------Vehicle Information-------------------");
            Console.WriteLine($"ID: {IdVehicle}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"----------------------------------------------------------");
        }
    }
}
