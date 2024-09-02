using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace POO.BankAccounts
{
    public class BankAccountRepository
    {
        private List<BankAccount> _bankAccounts;
        public BankAccountRepository()
        {
            _bankAccounts = new List<BankAccount>();
        }
        public void AddAccounts()
        {
            #region CREATE ACCOUNTS
            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 1,
                AccountNumber = "HYRULE-123456",
                AccountHolderName = "Master Chief",
                Balance = 10000.00m,
                AccountType = "Checking",
                InterestRate = 0.10m,
                RoutingNumber = "GALACTIC-BANK",
                Currency = "Rupees",
                IsActive = true,
            });
            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 2,
                AccountNumber = "AZEROTH-789012",
                AccountHolderName = "Jaina Proudmoore",
                Balance = 50000.00m,
                AccountType = "Savings",
                InterestRate = 0.05m,
                RoutingNumber = "STORMWIND-BANK",
                Currency = "Gold",
                IsActive = true,
            });
            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 3,
                AccountNumber = "SPARTAN-343",
                AccountHolderName = "Cortana",
                Balance = 1000000.00m,
                AccountType = "AI",
                InterestRate = 0.20m,
                RoutingNumber = "FORUNSCULPTUM-BANK",
                Currency = "Credits",
                IsActive = true,
            });
            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 4,
                AccountNumber = "MIDDLE_EARTH-456789",
                AccountHolderName = "Frodo Baggins",
                Balance = 15000.00m,
                AccountType = "Savings",
                InterestRate = 0.04m,
                RoutingNumber = "SHIRE-BANK",
                Currency = "Gold",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 5,
                AccountNumber = "NARNIA-321654",
                AccountHolderName = "Aslan",
                Balance = 25000.00m,
                AccountType = "Checking",
                InterestRate = 0.03m,
                RoutingNumber = "WARDROBE-BANK",
                Currency = "Silver",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 6,
                AccountNumber = "WAKANDA-987654",
                AccountHolderName = "T'Challa",
                Balance = 200000.00m,
                AccountType = "Investment",
                InterestRate = 0.08m,
                RoutingNumber = "WAKANDA-BANK",
                Currency = "Vibranium",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 7,
                AccountNumber = "HOGWARTS-654321",
                AccountHolderName = "Harry Potter",
                Balance = 30000.00m,
                AccountType = "Checking",
                InterestRate = 0.06m,
                RoutingNumber = "GRINGOTTS-BANK",
                Currency = "Galleons",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 8,
                AccountNumber = "GOTHAM-111222",
                AccountHolderName = "Bruce Wayne",
                Balance = 500000.00m,
                AccountType = "Savings",
                InterestRate = 0.07m,
                RoutingNumber = "WAYNE-BANK",
                Currency = "Dollars",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 9,
                AccountNumber = "KRYPTON-222333",
                AccountHolderName = "Clark Kent",
                Balance = 75000.00m,
                AccountType = "Checking",
                InterestRate = 0.05m,
                RoutingNumber = "DAILY-PLANET-BANK",
                Currency = "Dollars",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 10,
                AccountNumber = "PANDORA-333444",
                AccountHolderName = "Jake Sully",
                Balance = 12000.00m,
                AccountType = "Savings",
                InterestRate = 0.09m,
                RoutingNumber = "AVATAR-BANK",
                Currency = "Credits",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 11,
                AccountNumber = "FUTURE-444555",
                AccountHolderName = "Marty McFly",
                Balance = 60000.00m,
                AccountType = "Investment",
                InterestRate = 0.12m,
                RoutingNumber = "HILL-VALLEY-BANK",
                Currency = "Dollars",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 12,
                AccountNumber = "RIVEN-555666",
                AccountHolderName = "Riven",
                Balance = 80000.00m,
                AccountType = "Savings",
                InterestRate = 0.11m,
                RoutingNumber = "RIVEN-BANK",
                Currency = "Crystals",
                IsActive = true,
            });

            _bankAccounts.Add(new BankAccount()
            {
                IdAccount = 13,
                AccountNumber = "VALHALLA-666777",
                AccountHolderName = "Thor",
                Balance = 300000.00m,
                AccountType = "Checking",
                InterestRate = 0.10m,
                RoutingNumber = "ASGARD-BANK",
                Currency = "Gold",
                IsActive = true,
            });

            #endregion
        }
        public void GetAccounts()
        {
            for (int i = 0; i < _bankAccounts.Count; i++)
            {
                _bankAccounts[i].PrintAccountDetails();
            }
        }
        public void GetBankAccount(int idAccount)
        {
            BankAccount bankAccount = _bankAccounts.Where(b => b.IdAccount == idAccount).FirstOrDefault();
            if (bankAccount == null)
            {
                Console.WriteLine("No bank account found");
            }
            else
            {
                bankAccount.PrintAccountDetails();
            }
        }
        public void GetAccountByNumber(string accountNumber)
        {
            BankAccount bankAccount = _bankAccounts.Where(b => b.AccountNumber.Equals(accountNumber)).FirstOrDefault();
            if (bankAccount == null)
            {
                Console.WriteLine("No bank account found");
            }
            else
            {
                bankAccount.PrintAccountDetails();
            }
        }
        public void GetAccountByHolderName(string holderName)
        {
            BankAccount bankAccount = _bankAccounts.Where(b => b.AccountHolderName.Equals(holderName)).FirstOrDefault();
            if (bankAccount == null)
            {
                Console.WriteLine("No bank account found");
            }
            else
            {
                bankAccount.PrintAccountDetails();
            }
        }
        public void GetInactiveAccounts()
        {
            List<BankAccount> bankAccounts = _bankAccounts.Where(b => !b.IsActive).ToList();
            if (bankAccounts.Count > 0)
            {
                for (int i = 0; i < bankAccounts.Count; i++)
                {
                    bankAccounts[i].PrintAccountDetails();
                }
            }
            else
            {
                Console.WriteLine("All accounts are active");
            }
        }
        public void GetZeroBalanceAccounts()
        {
            List<BankAccount> bankAccounts = _bankAccounts.Where(b => b.Balance == 0).ToList();
            if (bankAccounts.Count > 0)
            {
                for (int i = 0; i < bankAccounts.Count; i++)
                {
                    bankAccounts[i].PrintAccountDetails();
                }
            }
        }
        public void GetBalanceGreaterThan(decimal amount)
        {
            List<BankAccount> bankAccounts = _bankAccounts.Where(b => b.Balance > amount).ToList();
            Console.WriteLine("\n Accounts with a balance greater than " + amount);
            Console.WriteLine(bankAccounts.Count);
            if (bankAccounts.Count > 0)
            {
                for (int i = 0; i < bankAccounts.Count; i++)
                {
                    bankAccounts[i].PrintAccountDetails();
                }
            }
        }
        public void TransferMoney(string originAccount, string destinyAccount, decimal amount)
        {
            BankAccount origin = _bankAccounts.Where(b => b.AccountNumber.Equals(originAccount)).FirstOrDefault();
            BankAccount destiny = _bankAccounts.Where(b => b.AccountNumber.Equals(destinyAccount)).FirstOrDefault();
            if (origin != null || destiny != null)
            {
                Console.WriteLine($"Origin balance: {origin.Balance}");
                Console.WriteLine($"Destiny balance: {destiny.Balance}");

                origin.Withdraw(amount);
                destiny.Deposit(amount);

                Console.WriteLine("NEW BALANCE");
                Console.WriteLine($"Origin balance: {origin.Balance}");
                Console.WriteLine($"Destiny balance: {destiny.Balance}");

            }
            else
            {
                Console.WriteLine("No account with this number");
            }
            
        }
    }
}
