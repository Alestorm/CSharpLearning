using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Persons
{
    public class PersonRepository
    {
        private List<Person> _persons;

        public PersonRepository()
        {
            _persons = new List<Person>();
        }
        public void AddPersons()
        {
            #region List with new names
            _persons.Add(new Person()
            {
                IdPerson = 2,
                Name = "Link",
                LastName = "of Hyrule",
                Genre = "Male",
                Dni = "12345678",
                Country = "Hyrule",
                City = "Castle Town",
                BirthDate = new DateTime(1986, 2, 21),
                Profession = "Hero",
                Address = "Kokiri Forest",
                CivilState = "Single",
                Phone = "555-987654",
                Email = "link@hyrule.com",
                BloodType = "O+",
                SocialNumber = "87-65-4321",
            });

            _persons.Add(new Person()
            {
                IdPerson = 3,
                Name = "Lara",
                LastName = "Croft",
                Genre = "Female",
                Dni = "24681012",
                Country = "United Kingdom",
                City = "London",
                BirthDate = new DateTime(1968, 2, 14),
                Profession = "Archaeologist",
                Address = "Croft Manor",
                CivilState = "Single",
                Phone = "555-246810",
                Email = "lara.croft@tomb-raider.com",
                BloodType = "AB+",
                SocialNumber = "13-57-9246",
            });

            _persons.Add(new Person()
            {
                IdPerson = 4,
                Name = "Mario",
                LastName = "Bros",
                Genre = "Male",
                Dni = "13579246",
                Country = "Mushroom Kingdom",
                City = "Peach's Castle",
                BirthDate = new DateTime(1981, 7, 9),
                Profession = "Plumber",
                Address = "Mushroom Kingdom",
                CivilState = "Single",
                Phone = "555-13579",
                Email = "mario@mushroom-kingdom.com",
                BloodType = "B+",
                SocialNumber = "24-68-1012",
            });

            _persons.Add(new Person()
            {
                IdPerson = 5,
                Name = "Samus",
                LastName = "Aran",
                Genre = "Female",
                Dni = "86420864",
                Country = "Zebes",
                City = "Norfair",
                BirthDate = new DateTime(1979, 3, 16),
                Profession = "Bounty Hunter",
                Address = "Gunship",
                CivilState = "Single",
                Phone = "555-86420",
                Email = "samus@zebes.com",
                BloodType = "AB-",
                SocialNumber = "97-53-1864",
            });

            _persons.Add(new Person()
            {
                IdPerson = 6,
                Name = "Kratos",
                LastName = "of Sparta",
                Genre = "Male",
                Dni = "97531864",
                Country = "Greece",
                City = "Sparta",
                BirthDate = new DateTime(973, 6, 20),
                Profession = "God of War",
                Address = "Mount Olympus",
                CivilState = "Married",
                Phone = "555-97531",
                Email = "kratos@mountolympus.com",
                BloodType = "O-",
                SocialNumber = "86-42-0864",
            });

            _persons.Add(new Person()
            {
                IdPerson = 7,
                Name = "Jill",
                LastName = "Valentine",
                Genre = "Female",
                Dni = "13975315",
                Country = "United States",
                City = "Raccoon City",
                BirthDate = new DateTime(1974, 4, 19),
                Profession = "S.T.A.R.S. Member",
                Address = "Apartment in Raccoon City",
                CivilState = "Single",
                Phone = "555-13975",
                Email = "jill@stars.com",
                BloodType = "A-",
                SocialNumber = "97-53-1315",
            });

            _persons.Add(new Person()
            {
                IdPerson = 8,
                Name = "Gordon",
                LastName = "Freeman",
                Genre = "Male",
                Dni = "97531315",
                Country = "United States",
                City = "Black Mesa",
                BirthDate = new DateTime(1956, 8, 8),
                Profession = "Scientist",
                Address = "Black Mesa Research Facility",
                CivilState = "Single",
                Phone = "555-97531",
                Email = "gordon@blackmesa.com",
                BloodType = "B-",
                SocialNumber = "13-97-5315",
            });

            _persons.Add(new Person()
            {
                IdPerson = 9,
                Name = "Solid",
                LastName = "Snake",
                Genre = "Male",
                Dni = "86420864",
                Country = "United States",
                City = "Shadow Moses",
                BirthDate = new DateTime(1972, 8, 25),
                Profession = "Soldier",
                Address = "Philanthropy Helicopter",
                CivilState = "Single",
                Phone = "555-86420",
                Email = "snake@philanthropy.com",
                BloodType = "O+",
                SocialNumber = "86-42-0864",
            });

            _persons.Add(new Person()
            {
                IdPerson = 10,
                Name = "Cloud",
                LastName = "Strife",
                Genre = "Male",
                Dni = "12312312",
                Country = "Gaia",
                City = "Midgar",
                BirthDate = new DateTime(1985, 8, 11),
                Profession = "Mercenary",
                Address = "Sector 7",
                CivilState = "Single",
                Phone = "555-123123",
                Email = "cloud@gaia.com",
                BloodType = "AB+",
                SocialNumber = "12-34-56-78",
            });
            #endregion
        }
        public void GetPersons()
        {
            Console.WriteLine("\nPERSON LIST");
            for (int i = 0; i < _persons.Count; i++)
            {
                _persons[i].PrintFullInfo();
            }
        }
        public void ListPersonsDni()
        {
            Console.WriteLine("\nLIST PERSON BY DNI");
            for (int i = 0; i < _persons.Count; i++)
            {
                _persons[i].PrintDni();
            }
        }
        public void OrderByCountry()
        {
            Console.WriteLine("\nLIST PERSON BY COUNTRY");
            List<Person> countryOrdered = _persons.OrderBy(person => person.Country).ToList();
            for (int i = 0; i < countryOrdered.Count; i++)
            {
                countryOrdered[i].PrintCountry();
            }
        }
        public void GetByBloodType(string bloodType)
        {
            Console.WriteLine("\nLIST PERSON WITH BLOOD TYPE: " + bloodType);
            List<Person> bloods = _persons.Where(p => p.BloodType.Contains(bloodType)).ToList();
            for (int i = 0; i < bloods.Count; i++)
            {
                bloods[i].PrintName();
            }
        }
    }
}
