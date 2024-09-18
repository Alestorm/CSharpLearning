using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Employee_Department
{
    public class DepartmentRepository
    {
        private List<Department> _departments = new List<Department>();

        public void AddDepartment(Department department)
        {
            _departments.Add(department);
        }
        public void ListDepartments()
        {
            for (int i = 0; i < _departments.Count; i++)
            {
                _departments[i].DepartmentInfo();
            }
        }
        public Department GetDepartmentByName(string name)
        {
            Department department = _departments.FirstOrDefault(x => x.Name.Equals(name));
            return department;
        }
    }
}
