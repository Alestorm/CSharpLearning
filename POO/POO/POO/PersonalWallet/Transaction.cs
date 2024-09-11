using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PersonalWallet
{
    public class Transaction
    {
        public int IdTransaction { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Currency { get; set; }
        public int Type { get; set; }//0 = expense, 1 = income
        public DateTime Date { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public void PrintTransactionInfo()
        {
            Console.WriteLine($"Transaction ID: {IdTransaction}");
            Console.WriteLine($"Amount: {(Type == 0 ? -1 * Amount : Amount)} {Currency}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Type: {(Type == 0 ? "Expense" : "Income")}");
            Console.WriteLine($"Date: {Date.ToShortDateString()}");
            Console.WriteLine($"Creation Date: {CreationDate.ToShortDateString()}");
            Console.WriteLine();
        }
    }
}
