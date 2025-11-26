using System;

namespace CSharp_Fundaments.OOPS_Concepts
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
    }

    internal class InheritanceWithObject
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Alex";
            Console.WriteLine("Student Name: " + student.Name);
        }
    }
}
