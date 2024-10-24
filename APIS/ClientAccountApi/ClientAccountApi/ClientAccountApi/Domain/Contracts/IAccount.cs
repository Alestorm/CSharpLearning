using ClientAccountApi.Domain.Models;

namespace ClientAccountApi.Domain.Contracts
{
    public interface IAccount
    {
        Result<Account> AddAccount(Account account);
        Result<Account> GetAccount(int idAccount);
        Result<List<Account>> GetAccounts(int idClient);
        Result<decimal> Deposit(decimal amount, string accountNumber);
        Result<decimal> Transfer(decimal amount, string originAccount, string destinyAccount);
    }
}
