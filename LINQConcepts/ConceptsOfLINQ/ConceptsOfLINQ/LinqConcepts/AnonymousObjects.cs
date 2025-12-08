using System;
using System.Collections.Generic;
using System.Linq;

namespace ConceptsOfLINQ.LinqConcepts
{
    class StudentDetails
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    internal class AnonymousObjects
    {
        static void Main(string[] args)
        {
            List<StudentDetails> studentsDetails = new List<StudentDetails>
            {
                new StudentDetails { Name = "Nishant", Marks = 85 },
                new StudentDetails { Name = "Aman", Marks = 90 }
            };

            var newData = studentsDetails.Select(s => new
            {
                StudentName = s.Name,
                Grade = s.Marks >= 90 ? "A" : "B"
            });

            foreach (var item in newData)
            {
                Console.WriteLine($"Name: {item.StudentName}, Grade: {item.Grade}");
            }
        }
    }
}
