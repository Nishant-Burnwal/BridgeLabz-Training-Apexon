using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfLINQ.LINQInAHour
{
    class EmployeeDepartment
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public EmployeeDepartment(string name, int departmentId)
        {
            Name = name;
            DepartmentId = departmentId;
        }
    }

    class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
    }

    internal class JoinLINQ
    {
        static void Main(string[] args)
        {
            var users = new List<EmployeeDepartment>()
            {
                new EmployeeDepartment("Nishant", 1),
                new EmployeeDepartment("Sneha", 1),
                new EmployeeDepartment("Amit", 2),
                new EmployeeDepartment("Neha", 2),
                new EmployeeDepartment("Aman", 3),
                new EmployeeDepartment("Anne", 3),
            };

            var departments = new List<Department>()
            {
                new Department { Id = 1, DeptName = "IT"},
                new Department { Id = 2, DeptName = "HR"},
                new Department { Id = 3, DeptName = "Sales"},
            };

            // Join users and departments
            var result = users.Join(
                departments,
                u => u.DepartmentId,
                d => d.Id,
                (u, d) => new
                {
                    u.Name,
                    d.DeptName
                }
            );

            // Print results
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} work in {item.DeptName} department");
            }
        }
    }
}
