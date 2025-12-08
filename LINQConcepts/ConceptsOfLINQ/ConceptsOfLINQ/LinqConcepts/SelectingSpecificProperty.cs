using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfLINQ.LinqConcepts
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }
    internal class SelectingSpecificProperty
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){
            new Student { Name = "Nishant", Marks = 85},
            new Student { Name = "Aman", Marks = 90}
            };

            var namesOnly = students.Select(s => s.Name);
            Console.WriteLine($"The names of students are: ");
            foreach (var name in namesOnly)
            {
                Console.WriteLine(name);
            }

        }
    }
}
