namespace VehiclesApi.Models
{
    public class Vehicle
    {
        public int IdVehicle { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public int HorsePower { get; set; }
        public double FuelCapacity { get; set; }
        public string FuelType { get; set; }
        public double Mileage { get; set; }
        public int Transmission { get; set; }
        public int NumberOfDoors { get; set; }
        public bool IsElectric { get; set; }
        public double MaxSpeed { get; set; }
        public string Plate { get; set; }
        public bool IsInsured { get; set; }
    }
}