using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PersonalWallet
{
    public class Person
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Person()
        {
            Transactions = new List<Transaction>();
        }
        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }


        public void GetTransactions()
        {
            Console.WriteLine($"\n{Name} {Lastname} transactions");
            for (int i = 0; i < Transactions.Count; i++)
            {
                Transactions[i].PrintTransactionInfo();
            }
        }
        public void ShowTotal()
        {
            decimal tExpense = Transactions.Where(t => t.Type == 0).Sum(t => t.Amount);
            decimal tIncome = Transactions.Where(t => t.Type == 1).Sum(t => t.Amount);
            Console.WriteLine();
            Console.WriteLine("Total expenses: " + -1*tExpense);
            Console.WriteLine("Total income: " + tIncome);
        }
    }
}