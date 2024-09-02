using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.BankAccounts
{
    public class BankAccount
    {
        public int IdAccount { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public decimal InterestRate { get; set; }
        public string RoutingNumber { get; set; }
        public string Currency { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance > 0 && Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Unsufficient funds");
            }
        }
        public void CloseAccount()
        {
            IsActive = false;
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine($"\tAccount ID: {IdAccount}");
            Console.WriteLine($"\tAccount Number: {AccountNumber}");
            Console.WriteLine($"\tAccount Holder Name: {AccountHolderName}");
            Console.WriteLine($"\tBalance:  {Balance}"); // Format balance as currency
            Console.WriteLine($"\tAccount Type: {AccountType}");
            Console.WriteLine($"\tInterest Rate: {InterestRate:P}"); // Format interest rate as percentage
            Console.WriteLine($"\tRouting Number: {RoutingNumber}");
            Console.WriteLine($"\tCurrency: {Currency}");
            Console.WriteLine($"\tIs Active: {IsActive}");
            Console.WriteLine($"\tCreation Date: {CreationDate:yyyy-MM-dd}"); // Format date as YYYY-MM-DD
        }
    }
}
