using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Persons
{
    public class PersonsMain
    {
        public void Main()
        {
            PersonRepository personRepository = new PersonRepository();
            personRepository.AddPersons();
            personRepository.GetPersons();
            personRepository.ListPersonsDni();
            personRepository.OrderByCountry();
            personRepository.GetByBloodType("AB");
        }
    }
}
