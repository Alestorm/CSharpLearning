using VehiclesApi.Models;

namespace VehiclesApi.Repositories
{
    public interface IVehicleRepository
    {
        Vehicle AddVehicle(Vehicle vehicle);
        Vehicle FindById(int idVehicle);
        List<Vehicle> GetAll();
        List<Vehicle> ListAutomatic();
        List<Vehicle> OrderByYear(bool desc);
        List<Vehicle> ListByBrand(string brand);
        Dictionary<string, List<Vehicle>> ShowBrands();
    }
}
