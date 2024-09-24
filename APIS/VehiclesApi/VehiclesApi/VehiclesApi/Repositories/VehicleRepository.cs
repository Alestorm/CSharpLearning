using VehiclesApi.Models;
using Newtonsoft.Json;

namespace VehiclesApi.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            FileManager.SaveVehicle(JsonConvert.SerializeObject(vehicle));
            return vehicle;
        }

        public Vehicle FindById(int idVehicle)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAll()
        {
            return GetVehicleList();
        }

        public List<Vehicle> ListAutomatic()
        {
            var vehicles = GetVehicleList();
            return vehicles.OrderBy(v => v.Transmission).ToList();
        }

        public List<Vehicle> ListByBrand(string brand)
        {
            var vehicles = GetVehicleList();
            return vehicles.Where(v => v.Brand.Equals(brand)).ToList();
        }

        public Dictionary<string, List<Vehicle>> ShowBrands()
        {
            var vehicles = GetVehicleList();
            Dictionary<string, List<Vehicle>> brands = new Dictionary<string, List<Vehicle>>();

            foreach (var vehicle in vehicles)
            {
                if (!brands.ContainsKey(vehicle.Brand))
                {
                    brands.Add(vehicle.Brand, new List<Vehicle>());
                }
                brands[vehicle.Brand].Add(vehicle);
            }
            return brands;
        }

        public List<Vehicle> OrderByYear(bool desc)
        {
            var vehicles = GetVehicleList();
            return desc ? vehicles.OrderByDescending(v => v.Year).ToList() : vehicles.OrderBy(v => v.Year).ToList();
        }
        public static List<Vehicle> GetVehicleList()
        {
            string list = FileManager.ReadVehicles();
            return JsonConvert.DeserializeObject<List<Vehicle>>(list);
        }
    }
}
