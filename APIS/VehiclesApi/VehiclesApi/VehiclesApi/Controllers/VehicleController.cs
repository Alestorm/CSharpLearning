using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiclesApi.Models;
using VehiclesApi.Repositories;

namespace VehiclesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        [HttpPost]
        public IActionResult AddVehicle([FromBody] Vehicle vehicle)
        {
            var newVehicle = _vehicleRepository.AddVehicle(vehicle);
            return Created("", newVehicle);
        }
        [HttpGet]
        public IActionResult Getall()
        {
            return Ok(_vehicleRepository.GetAll());
        }
        [HttpGet("automatic")]
        public IActionResult ListAutomatic()
        {
            return Ok(_vehicleRepository.ListAutomatic());
        }
        [HttpGet("brands")]
        public IActionResult ShowBrands()
        {
            return Ok(_vehicleRepository.ShowBrands());
        }

    }
}
