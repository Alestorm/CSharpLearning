using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Vehicles
{
    public class VehicleRepository
    {
        private List<Vehicle> _vehicles;
        public VehicleRepository()
        {
            _vehicles = new List<Vehicle>();
        }
        public void AddVehicles()
        {
            #region List with new vehicles
            // Agregar vehículos a la lista
            _vehicles.Add(new Vehicle
            {
                IdVehicle = 1,
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2020,
                Color = "White",
                VIN = "1HGBH41JXMN109186",
                EngineSize = 1.8,
                HorsePower = 139,
                FuelCapacity = 50,
                FuelType = "Gasoline",
                Mileage = 12500,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 180,
                Plate = "ABC123",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 2,
                Brand = "Honda",
                Model = "Civic",
                Year = 2018,
                Color = "Gray",
                VIN = "2HGFG12678R123456",
                EngineSize = 2.0,
                HorsePower = 158,
                FuelCapacity = 47,
                FuelType = "Gasoline",
                Mileage = 25000,
                Transmission = "Manual",
                NumberOfDoors = 2,
                IsElectric = false,
                MaxSpeed = 200,
                Plate = "DEF456",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 3,
                Brand = "Tesla",
                Model = "Model S",
                Year = 2021,
                Color = "Black",
                VIN = "5YJ3E1EB5MF123456",
                EngineSize = 0,
                HorsePower = 670,
                FuelCapacity = 0,
                FuelType = "Electric",
                Mileage = 5000,
                Transmission = "Manual",
                NumberOfDoors = 4,
                IsElectric = true,
                MaxSpeed = 250,
                Plate = "GHI789",
                IsInsured = true
            });

            // Adding 10 more vehicles
            _vehicles.Add(new Vehicle
            {
                IdVehicle = 4,
                Brand = "Ford",
                Model = "Mustang",
                Year = 2020,
                Color = "Red",
                VIN = "1FA6P8TH4L5112345",
                EngineSize = 5.0,
                HorsePower = 450,
                FuelCapacity = 60,
                FuelType = "Gasoline",
                Mileage = 15000,
                Transmission = "Automatic",
                NumberOfDoors = 2,
                IsElectric = false,
                MaxSpeed = 250,
                Plate = "JKL012",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 5,
                Brand = "Chevrolet",
                Model = "Camaro",
                Year = 2019,
                Color = "Yellow",
                VIN = "1G1FB1RS8K0123456",
                EngineSize = 6.2,
                HorsePower = 455,
                FuelCapacity = 70,
                FuelType = "Gasoline",
                Mileage = 20000,
                Transmission = "Manual",
                NumberOfDoors = 2,
                IsElectric = false,
                MaxSpeed = 240,
                Plate = "MNO345",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 6,
                Brand = "Nissan",
                Model = "Leaf",
                Year = 2021,
                Color = "Green",
                VIN = "1N4AZ1CP1MC123456",
                EngineSize = 0,
                HorsePower = 147,
                FuelCapacity = 0,
                FuelType = "Electric",
                Mileage = 8000,
                Transmission = "Manual",
                NumberOfDoors = 4,
                IsElectric = true,
                MaxSpeed = 150,
                Plate = "PQR678",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 7,
                Brand = "BMW",
                Model = "3 Series",
                Year = 2020,
                Color = "Blue",
                VIN = "WBA5A5C55B1234567",
                EngineSize = 2.0,
                HorsePower = 255,
                FuelCapacity = 60,
                FuelType = "Gasoline",
                Mileage = 12000,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 240,
                Plate = "STU901",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 8,
                Brand = "Mercedes-Benz",
                Model = "C-Class",
                Year = 2021,
                Color = "Silver",
                VIN = "WDDWK4JB1JR123456",
                EngineSize = 2.0,
                HorsePower = 255,
                FuelCapacity = 66,
                FuelType = "Gasoline",
                Mileage = 5000,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 250,
                Plate = "VWX234",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 9,
                Brand = "Audi",
                Model = "A4",
                Year = 2020,
                Color = "Black",
                VIN = "WAUENAF4XK1234567",
                EngineSize = 2.0,
                HorsePower = 248,
                FuelCapacity = 54,
                FuelType = "Gasoline",
                Mileage = 11000,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 240,
                Plate = "YZA567",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 10,
                Brand = "Kia",
                Model = "Soul",
                Year = 2021,
                Color = "White",
                VIN = "KNDJ23AU7M1234567",
                EngineSize = 2.0,
                HorsePower = 147,
                FuelCapacity = 54,
                FuelType = "Gasoline",
                Mileage = 3000,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 180,
                Plate = "BCD890",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 11,
                Brand = "Subaru",
                Model = "Outback",
                Year = 2021,
                Color = "Bronze",
                VIN = "4S4BSAFC8K1234567",
                EngineSize = 2.5,
                HorsePower = 182,
                FuelCapacity = 63,
                FuelType = "Gasoline",
                Mileage = 4000,
                Transmission = "Manual",
                NumberOfDoors = 5,
                IsElectric = false,
                MaxSpeed = 200,
                Plate = "EFG123",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 12,
                Brand = "Hyundai",
                Model = "Elantra",
                Year = 2021,
                Color = "Red",
                VIN = "5NPD84LF9MH123456",
                EngineSize = 2.0,
                HorsePower = 147,
                FuelCapacity = 50,
                FuelType = "Gasoline",
                Mileage = 2500,
                Transmission = "Manual",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 210,
                Plate = "HIJ456",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 13,
                Brand = "Volkswagen",
                Model = "Golf",
                Year = 2020,
                Color = "Blue",
                VIN = "WVWDA7AJ9LW123456",
                EngineSize = 2.0,
                HorsePower = 228,
                FuelCapacity = 50,
                FuelType = "Gasoline",
                Mileage = 7000,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 220,
                Plate = "KLM789",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 14,
                Brand = "Porsche",
                Model = "911",
                Year = 2021,
                Color = "Yellow",
                VIN = "WP0AB2A95LS123456",
                EngineSize = 3.0,
                HorsePower = 379,
                FuelCapacity = 64,
                FuelType = "Gasoline",
                Mileage = 1500,
                Transmission = "Automatic",
                NumberOfDoors = 2,
                IsElectric = false,
                MaxSpeed = 300,
                Plate = "XYZ123",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 15,
                Brand = "Jaguar",
                Model = "F-Type",
                Year = 2021,
                Color = "Red",
                VIN = "SAJDA4B8XJ1234567",
                EngineSize = 5.0,
                HorsePower = 550,
                FuelCapacity = 65,
                FuelType = "Gasoline",
                Mileage = 2000,
                Transmission = "Manual",
                NumberOfDoors = 2,
                IsElectric = false,
                MaxSpeed = 300,
                Plate = "JKL456",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 16,
                Brand = "Fiat",
                Model = "500",
                Year = 2021,
                Color = "White",
                VIN = "3C3CFFBR8CT123456",
                EngineSize = 1.4,
                HorsePower = 101,
                FuelCapacity = 35,
                FuelType = "Gasoline",
                Mileage = 5000,
                Transmission = "Manual",
                NumberOfDoors = 2,
                IsElectric = false,
                MaxSpeed = 185,
                Plate = "ABC789",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 17,
                Brand = "Lexus",
                Model = "RX",
                Year = 2021,
                Color = "Silver",
                VIN = "2T2BZMCA7HC123456",
                EngineSize = 3.5,
                HorsePower = 295,
                FuelCapacity = 60,
                FuelType = "Gasoline",
                Mileage = 3000,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 210,
                Plate = "DEF012",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 18,
                Brand = "Mazda",
                Model = "CX-5",
                Year = 2021,
                Color = "Blue",
                VIN = "JM3KFBCM6M1234567",
                EngineSize = 2.5,
                HorsePower = 187,
                FuelCapacity = 56,
                FuelType = "Gasoline",
                Mileage = 4500,
                Transmission = "Automatic",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 200,
                Plate = "GHI234",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 19,
                Brand = "Chrysler",
                Model = "Pacifica",
                Year = 2021,
                Color = "Black",
                VIN = "2C4RC1FG9MR123456",
                EngineSize = 3.6,
                HorsePower = 287,
                FuelCapacity = 68,
                FuelType = "Gasoline",
                Mileage = 2000,
                Transmission = "Manual",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 180,
                Plate = "JKL345",
                IsInsured = true
            });

            _vehicles.Add(new Vehicle
            {
                IdVehicle = 20,
                Brand = "Volvo",
                Model = "XC90",
                Year = 2021,
                Color = "Gray",
                VIN = "YV4A22PK2M1234567",
                EngineSize = 2.0,
                HorsePower = 250,
                FuelCapacity = 71,
                FuelType = "Gasoline",
                Mileage = 3000,
                Transmission = "Manual",
                NumberOfDoors = 4,
                IsElectric = false,
                MaxSpeed = 220,
                Plate = "XYZ890",
                IsInsured = true
            });

            #endregion
        }
        public void ListVehicles()
        {
            for (int i = 0; i < _vehicles.Count; i++)
            {
                _vehicles[i].DisplayVehicleInfo();
            }
        }
        public void ListAutomatic()
        {

            List<Vehicle> automatics = _vehicles.Where(v => v.Transmission.Equals("Automatic")).ToList();

            Console.WriteLine("\nAUTOMATIC TRANSMISSION");
            Console.WriteLine("Count: " + automatics.Count);
            for (int i = 0; i < automatics.Count; i++)
            {
                automatics[i].DisplayBrandAndModel();
            }
        }
        public void OrderByYear()
        {
            List<Vehicle> orderedByYear = _vehicles.OrderBy(v => v.Year).ToList();
            Console.WriteLine("\nORDERED BY YEAR");
            for (int i = 0; i < orderedByYear.Count; i++)
            {
                orderedByYear[i].DisplayVehicleInfo();
            }
        }
        public void ListByBrand(string brand)
        {
            brand = brand.ToLower().Trim();
            List<Vehicle> brandVehicles = _vehicles.Where(v => v.Brand.ToLower().Equals(brand)).ToList();
            Console.WriteLine("\nCars from " + brand);
            for (int i = 0; i < brandVehicles.Count; i++)
            {
                brandVehicles[i].DisplayVehicleInfo();
            }
        }
    }
}
