using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PersonalWallet
{
    public class PersonalWalletMain
    {
        private List<Person> persons = new List<Person>();
        public void Main()
        {
            Person arthas = new Person()
            {
                IdUser = 1,
                Name = "Arthas",
                Lastname = "Menethil",
                Email = "arthas@lore.com",
                Phone = "555-0123",
                Address = "Crown guard keep, Lordaeron"
            };
            AddPerson(arthas);

            Person luna = new Person()
            {
                IdUser = 2,
                Name = "Luna",
                Lastname = "Nigthsong",
                Email = "luna@nigth.com",
                Phone = "555-9876",
                Address = "Elwyn Forest, Azeroth"
            };
            AddPerson(luna);

            arthas.AddTransaction(new Transaction() { IdTransaction = 1, Amount = 1500, Description = "Buy braceless", Category = "Equipment", Currency = "Gold", Type = 0, Date = new DateTime(2024, 8, 6) });
            arthas.AddTransaction(new Transaction() { IdTransaction = 2, Amount = 300, Description = "Buy potions", Category = "Consumables", Currency = "Gold", Type = 0, Date = new DateTime(2024, 8, 15) });
            arthas.AddTransaction(new Transaction() { IdTransaction = 3, Amount = 500, Description = "Sell materials", Category = "Sells", Currency = "Gold", Type = 1, Date = new DateTime(2024, 9, 11) });

            luna.AddTransaction(new Transaction() { IdTransaction = 1, Amount = 1200, Description = "Buy magic bow", Category = "Equipment", Currency = "Gold", Type = 0, Date = new DateTime(2024, 7, 3) });
            luna.AddTransaction(new Transaction() { IdTransaction = 2, Amount = 450, Description = "Mana elixir", Category = "Consumables", Currency = "Silver", Type = 0, Date = new DateTime(2024, 8, 10) });
            luna.AddTransaction(new Transaction() { IdTransaction = 3, Amount = 800, Description = "Sell gems", Category = "Sells", Currency = "Silver", Type = 1, Date = new DateTime(2024, 9, 11) });


            arthas.GetTransactions();
            arthas.ShowTotal();

            luna.GetTransactions();
            luna.ShowTotal();


        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
    }
}
