using ContactsApi.Controllers.Dtos.ContactDtos;
using ContactsApi.Models;
using ContactsApi.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IUser _userRepository;
        private readonly IContact _contactRepository;

        public ContactController(IUser userRepository, IContact contactRepository)
        {
            _contactRepository = contactRepository;
            _userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult AddContact([FromBody] AddContactDto addContactDto)
        {
            try
            {
                var user = _userRepository.GetUser(addContactDto.IdUser);
                if (user == null)
                {
                    return BadRequest("User not found");
                }
                Contact contact = new Contact()
                {
                    Name = addContactDto.Name,
                    Lastname = addContactDto.Lastname,
                    Email = addContactDto.Email,
                    PhoneNumber = addContactDto.PhoneNumber,
                    MobileNumber = addContactDto.MobileNumber,
                    Address = addContactDto.Address,
                    City = addContactDto.City,
                    Country = addContactDto.Country,
                    Company = addContactDto.Company,
                    JobTitle = addContactDto.JobTitle,
                    DateOfBirth = addContactDto.DateOfBirth,
                    Notes = addContactDto.Notes,
                    User = user,
                    IdUser = user.IdUser,
                };
                _contactRepository.AddContact(contact);
                return Created("", contact);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("user/{idUser}")]
        public IActionResult GetContacts([FromRoute] int idUser)
        {
            try
            {
                return Ok(_contactRepository.GetAllContacts(idUser));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("user/{id}/contacts")]
        public IActionResult SearchContacts([FromRoute] int id, [FromQuery] string term)
        {
            try
            {
                if (term.Length < 2)
                {
                    return BadRequest("Term minimum length is 2 characters");
                }
                return Ok(_contactRepository.SearchContacts(id, term));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateContact([FromRoute] int id, [FromBody] AddContactDto addContactDto)
        {
            try
            {
                Contact contact = new Contact()
                {
                    Name = addContactDto.Name,
                    Lastname = addContactDto.Lastname,
                    Email = addContactDto.Email,
                    PhoneNumber = addContactDto.PhoneNumber,
                    MobileNumber = addContactDto.MobileNumber,
                    Address = addContactDto.Address,
                    City = addContactDto.City,
                    Country = addContactDto.Country,
                    Company = addContactDto.Company,
                    JobTitle = addContactDto.JobTitle,
                    DateOfBirth = addContactDto.DateOfBirth,
                    Notes = addContactDto.Notes
                };
                return Ok(_contactRepository.UpdateContact(id, contact));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("setFavorite/{id}")]
        public IActionResult UpdateFavorite([FromRoute] int id)
        {
            try
            {
                _contactRepository.UpdateFavorite(id);
                return Ok();
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
