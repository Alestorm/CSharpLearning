
using ClientAccountApi.Controllers.Dtos.ClientDtos;
using ClientAccountApi.Domain.Contracts;
using ClientAccountApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientAccountApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClient _clientRepository;
        public ClientController(IClient clientRepository)
        {
            _clientRepository = clientRepository;
        }
        [HttpPost]
        public IActionResult AddClient([FromBody] NewClientDto newClientDto)
        {
            try
            {
                Client client = new Client()
                {
                    Name = newClientDto.Name,
                    Lastname = newClientDto.Lastname,
                    Email = newClientDto.Email,
                    Phone = newClientDto.Phone,
                    Address = newClientDto.Address,
                    City = newClientDto.City,
                    IdNumber = newClientDto.IdNumber,
                };

                var result = _clientRepository.AddClient(client);
                if (!result.IsSuccess)
                {
                    return Conflict(result.ErrorMessage);
                }
                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetClient([FromRoute] int id)
        {
            try
            {
                var result = _clientRepository.GetClient(id);
                return result.IsSuccess ? Ok(result.Value) : NotFound(result.ErrorMessage);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetClients()
        {
            try
            {
                return Ok(_clientRepository.GetClients().Value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("search/client")]
        public IActionResult SearchClient([FromQuery] string query)
        {
            try
            {
                if (query.Length < 2)
                {
                    return BadRequest("Needs to be at least 2 characters");
                }
                return Ok(_clientRepository.SearchClient(query).Value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}