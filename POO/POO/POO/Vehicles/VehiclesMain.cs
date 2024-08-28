using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Vehicles
{
    public class VehiclesMain
    {
        public void Main()
        {
            VehicleRepository vehicleRepository = new VehicleRepository();
            vehicleRepository.AddVehicles();
            vehicleRepository.ListVehicles();
            vehicleRepository.ListAutomatic();
            vehicleRepository.OrderByYear();
            vehicleRepository.ListByBrand("tesla");
        }
    }
}
