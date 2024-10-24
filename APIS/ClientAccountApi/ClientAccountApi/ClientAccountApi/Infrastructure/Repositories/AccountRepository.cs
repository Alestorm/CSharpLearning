using ClientAccountApi.Domain.Contracts;
using ClientAccountApi.Domain.Models;
using ClientAccountApi.Infrastructure.MySqlDatabase;

namespace ClientAccountApi.Infrastructure.Repositories
{
    public class AccountRepository : IAccount
    {
        private readonly MySqlDbContext _context;
        public AccountRepository(MySqlDbContext context)
        {
            _context = context;
        }

        public Result<Account> AddAccount(Account account)
        {
            Client client = _context.Clients.FirstOrDefault(c => c.IdClient == account.IdClient);
            if (client == null)
            {
                return Result<Account>.Failure("Client doesn't exist");
            }
            account.Client = client;

            if (_context.Accounts.Any(a => a.AccountNumber.Equals(account.AccountNumber)))
            {
                return Result<Account>.Failure("Account already exists");
            }
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return Result<Account>.Success(account);
        }

        public Result<decimal> Deposit(decimal amount, string accountNumber)
        {
            var findAccount = _context.Accounts.FirstOrDefault(a => a.AccountNumber.Equals(accountNumber));
            if (findAccount == null)
            {
                return Result<decimal>.Failure("Couldn't find account");
            }
            decimal currentBalance = findAccount.Balance;
            findAccount.Balance = currentBalance + amount;
            _context.SaveChanges();
            return Result<decimal>.Success(findAccount.Balance);
        }

        public Result<Account> GetAccount(int idAccount)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.IdAccount == idAccount);
            if (account == null)
            {
                return Result<Account>.Failure("Couldn't find account");
            }
            return Result<Account>.Success(account);
        }

        public Result<List<Account>> GetAccounts(int idClient)
        {
            var accounts = _context.Accounts.Where(a => a.IdClient == idClient).ToList();
            return Result<List<Account>>.Success(accounts);
        }

        public Result<decimal> Transfer(decimal amount, string originAccount, string destinyAccount)
        {
            var origin = _context.Accounts.FirstOrDefault(a => a.AccountNumber.Equals(originAccount));
            if (origin == null)
            {
                return Result<decimal>.Failure($"{originAccount} was not found");
            }
            if (origin.Balance < amount)
            {
                return Result<decimal>.Failure("Not enough balance");
            }

            var destiny = _context.Accounts.FirstOrDefault(a => a.AccountNumber.Equals(destinyAccount));
            if (destiny == null)
            {
                return Result<decimal>.Failure($"{destinyAccount} was not found");
            }

            origin.Balance -= amount;

            destiny.Balance += amount;

            _context.SaveChanges();

            return Result<decimal>.Success(origin.Balance);

        }
    }
}
