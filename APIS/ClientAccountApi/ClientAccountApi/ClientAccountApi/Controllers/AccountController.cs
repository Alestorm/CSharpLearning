using ClientAccountApi.Controllers.Dtos.AccountDtos;
using ClientAccountApi.Domain.Contracts;
using ClientAccountApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientAccountApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _accountRepository;
        public AccountController(IAccount accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [HttpPost]
        public IActionResult AddAccount([FromBody] NewAccountDto newAccountDto)
        {
            Account account = new Account()
            {
                AccountNumber = newAccountDto.AccountNumber,
                Balance = newAccountDto.Balance,
                Interest = newAccountDto.Interest,
                Type = newAccountDto.Type,
                IdClient = newAccountDto.IdClient
            };
            var response = _accountRepository.AddAccount(account);
            if (!response.IsSuccess)
            {
                return BadRequest(response.ErrorMessage);
            }
            response.Value.Client = null;
            return Ok(response.Value);

        }
        [HttpGet("client/{id}")]
        public IActionResult GetAccounts([FromRoute] int id)
        {
            var response = _accountRepository.GetAccounts(id);
            return Ok(response.Value);
        }
        [HttpPost("deposit")]
        public IActionResult Deposit([FromBody] DepositDto depositDto)
        {
            if (depositDto.Amount <= 0)
            {
                return BadRequest("Amount cannot be 0 or less than zero");
            }
            var response = _accountRepository.Deposit(depositDto.Amount, depositDto.AccountNumber);
            if (!response.IsSuccess)
            {
                return BadRequest(response.ErrorMessage);
            }
            return Ok(response.Value);
        }
    }
}
