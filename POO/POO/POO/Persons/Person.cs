using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Persons
{
    public class Person
    {
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Genre { get; set; }
        public string Dni { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Profession { get; set; }
        public string Address { get; set; }
        public string CivilState { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }
        public string SocialNumber { get; set; }

        public void PrintFullInfo()
        {
            Console.WriteLine($"{IdPerson}. Full name: {Name} {LastName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine("Dni: " + Dni);
            Console.WriteLine("Country: " + Country);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Birth date: " + BirthDate.ToShortDateString());
            Console.WriteLine("Proffesion: " + Profession);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Civil state: " + CivilState);
            Console.WriteLine("Blood type: " + BloodType);
            Console.WriteLine("Social number: " + SocialNumber);
            Console.WriteLine("CONTACT INFORMATION");
            Console.WriteLine("Phone number: " + Phone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine();
        }
        public void PrintName()
        {
            Console.WriteLine(Name + " " + LastName);
        }
        public void PrintDni()
        {
            Console.WriteLine($"{IdPerson}. {Name} {LastName} - Dni: {Dni}");
        }
        public void PrintCountry()
        {
            Console.WriteLine($"{IdPerson}. {Name} {LastName} - Country: {Country}");
        }
    }
}
