using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.BankAccounts
{
    public class BankAccountsMain
    {
        public void Main()
        {
            BankAccountRepository bankAccountRepository = new BankAccountRepository();
            bankAccountRepository.AddAccounts();
            bankAccountRepository.GetAccounts();
            bankAccountRepository.GetBankAccount(12);
            bankAccountRepository.GetAccountByNumber("AZEROTH-789012");
            bankAccountRepository.GetAccountByHolderName("Frodo Baggins");
            bankAccountRepository.GetInactiveAccounts();
            bankAccountRepository.GetZeroBalanceAccounts();
            bankAccountRepository.GetBalanceGreaterThan(100000m);

            Console.WriteLine("TRANSFER CHECK");
            bankAccountRepository.GetAccountByNumber("SPARTAN-343");
            bankAccountRepository.GetAccountByNumber("WAKANDA-987654");
            Console.WriteLine("\n");
            bankAccountRepository.TransferMoney("SPARTAN-343", "WAKANDA-987654", 3025.05m);
            Console.WriteLine("\n");
            bankAccountRepository.GetAccountByNumber("SPARTAN-343");
            bankAccountRepository.GetAccountByNumber("WAKANDA-987654");
        }
    }
}
