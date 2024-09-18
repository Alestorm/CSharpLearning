using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Employee_Department
{
    public class Employee_Department
    {
        public void Main()
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            //departments creation
            Department gameDesign = new Department
            {
                IdDepartment = 1,
                Name = "Game Design",
                Description = "Responsible for designing and creating gameplay mechanics.",
                Location = "Building A, Floor 1",
                Budget = 400000m,
                Phone = "555-0101",
                Email = "gamedesign@videogames.com",
                Website = "www.videogames.com/gamedesign"
            };

            Department qualityAssurance = new Department
            {
                IdDepartment = 2,
                Name = "Quality Assurance",
                Description = "Ensures the quality and functionality of video games.",
                Location = "Building B, Floor 2",
                Budget = 250000m,
                Phone = "555-0202",
                Email = "qa@videogames.com",
                Website = "www.videogames.com/qualityassurance"
            };
            departmentRepository.AddDepartment(gameDesign);
            departmentRepository.AddDepartment(qualityAssurance);

            //employees creation

            Employee employee1 = new Employee
            {
                IdEmployee = 1,
                FirstName = "Link",
                LastName = "Hyrule",
                DateOfBirth = new DateTime(1986, 11, 21),
                Gender = 'M',
                Email = "link.hyrule@videogames.com",
                Phone = "555-1111",
                Address = "123 Hyrule Field, Hyrule",
                HireDate = new DateTime(2023, 5, 15),
                Salary = 80000m,
                Status = 1,
                Department = gameDesign
            };

            Employee employee2 = new Employee
            {
                IdEmployee = 2,
                FirstName = "Zelda",
                LastName = "Princess",
                DateOfBirth = new DateTime(1989, 9, 13),
                Gender = 'F',
                Email = "zelda.princess@videogames.com",
                Phone = "555-2222",
                Address = "456 Castle Town, Hyrule",
                HireDate = new DateTime(2023, 6, 10),
                Salary = 85000m,
                Status = 1,
                Department = gameDesign
            };

            Employee employee3 = new Employee
            {
                IdEmployee = 3,
                FirstName = "Samus",
                LastName = "Aran",
                DateOfBirth = new DateTime(1986, 10, 30),
                Gender = 'F',
                Email = "samus.aran@videogames.com",
                Phone = "555-3333",
                Address = "789 Tallon IV, Space Colony",
                HireDate = new DateTime(2023, 7, 5),
                Salary = 78000m,
                Status = 1,
                Department = qualityAssurance
            };

            Employee employee4 = new Employee
            {
                IdEmployee = 4,
                FirstName = "Mario",
                LastName = "Mushroom",
                DateOfBirth = new DateTime(1985, 3, 10),
                Gender = 'M',
                Email = "mario.mushroom@videogames.com",
                Phone = "555-4444",
                Address = "321 Mushroom Kingdom, Mario World",
                HireDate = new DateTime(2023, 8, 20),
                Salary = 72000m,
                Status = 1,
                Department = qualityAssurance
            };

            qualityAssurance.Employees.Add(employee1);
            qualityAssurance.Employees.Add(employee2);

            gameDesign.Employees.Add(employee3);
            gameDesign.Employees.Add(employee4);

            departmentRepository.ListDepartments();

            Department department = departmentRepository.GetDepartmentByName("Game Design");
            if (department != null)
            {
                for (int i = 0; i < department.Employees.Count; i++)
                {
                    department.Employees[i].EmployeeInfo();
                }
            }
            else
            {
                Console.WriteLine("There is not that department");
            }
        }
    }
}
