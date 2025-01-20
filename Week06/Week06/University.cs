using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    internal class University
    {
        public class University
        {
            public string Name { get; set; }
            public List<Department> Departments { get; set; }

            public University(string name)
            {
                Name = name;
                Departments = new List<Department>();
            }

            public void AddDepartment(Department department)
            {
                Departments.Add(department);
            }

            public void RemoveDepartment(Department department)
            {
                Departments.Remove(department);
            }
        }
    }
}
