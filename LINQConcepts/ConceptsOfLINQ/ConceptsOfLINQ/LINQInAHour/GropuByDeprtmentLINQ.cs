using System;
using System.Collections.Generic;
using System.Linq;

namespace ConceptsOfLINQ.LINQInAHour
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }

    internal class GroupByDepartmentLINQ
    {
        static void Main(string[] args)
        {
            // Creating list of employee users
            var users = new List<Employee>()
            {
                new Employee("Nishant", "IT"),
                new Employee("Sneha", "IT"),
                new Employee("Amit", "HR"),
                new Employee("Neha", "HR"),
                new Employee("Aman", "Sales"),
            };

            // Group by Department
            var groups = users.GroupBy(u => u.Department);

            // Printing groups
            foreach (var g in groups)
            {
                Console.WriteLine($"Department: {g.Key}");

                foreach (var u in g)
                {
                    Console.WriteLine($"  {u.Name}");
                }
            }
        }
    }
}
