using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Employee_Department
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public int Status { get; set; }
        public Department Department { get; set; }

        public void EmployeeInfo()
        {
            Console.WriteLine($"\n{FirstName} {LastName}");
            Console.WriteLine($"Birth date: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Contact: {Phone} - {Email}");
            Console.WriteLine(Address);
            Console.WriteLine($"Hire date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Department: {Department.Name}");
            Console.WriteLine($"Salary: {Salary}");
            switch (Status)
            {
                case 0:
                    Console.WriteLine("Active");
                    break;
                case 1:
                    Console.WriteLine("Inactive");
                    break;
                case 2:
                    Console.WriteLine("Fired");
                    break;
                default:
                    break;
            }
        }
    }
}
