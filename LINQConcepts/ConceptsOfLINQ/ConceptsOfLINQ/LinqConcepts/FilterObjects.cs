using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfLINQ.LinqConcepts
{
    class Employee
    {
        public string Name { get; set; } // auto properties
        public int Age { get; set; } // auto properties
        // get - read
        // set - write
    }
    /*
     *  private int _age;
        public int Age
        {
            get
            {
                Console.WriteLine("Getter called");
                return _age;
            }
            set
            {
                if (value < 0) throw new Exception("Age cannot be negative");
                _age = value;
            }
        }

     */
    /*
     * When should you use auto-properties?

        A->Use auto-properties when:
        You don't need validation
        You don't need logic inside getters/setters
        You just want simple storage of data
     */
    internal class FilterObjects
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee {Name = "Amit", Age = 22},
                new Employee {Name = "Vijay", Age = 30},
                new Employee {Name = "Aman", Age = 19},
            }; // created emps list 

            var adultsGreaterThan21 = emps.Where(e => e.Age >= 21); // filtered emp with age greater than 21

            Console.WriteLine("Employee With Age Greater than 21: ");
            foreach(var adult in adultsGreaterThan21)
                Console.WriteLine(adult.Name);
        }
    }
}
