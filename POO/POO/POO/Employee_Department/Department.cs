using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Employee_Department
{
    public class Department
    {
        public int IdDepartment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Budget { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public List<Employee> Employees { get; set; }
        public Department()
        {
            Employees = new List<Employee>();
        }

        public void DepartmentInfo()
        {
            Console.WriteLine($"\nDepartment: {Name}");
            Console.WriteLine(Description);
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Budget: {Budget}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Website: {Website}");
            Console.WriteLine($"Employee count: {Employees.Count}");
        }
    }
}
