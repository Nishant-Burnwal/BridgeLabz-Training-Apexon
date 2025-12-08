using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfLINQ.LinqConcepts
{
    internal class LINQBasics
    {
        //LINQ lets you query
        //(search, filter, sort, group, transform
        //data using simple, SQL-like syntax.
        /*
         * LINQ works on:

            1. Lists / Arrays
            2 .Dictionaries
            3. Strings
            4 .Databases (via LINQ-to-SQL / EF)
            5. XML
            6. Anything iterable

        Important LINQ Namespaces
        To use LINQ, always add:
        using System.Linq;
         */
        static void Main(string[] args)
        {
            // Given a list<int> filter all even numbers
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var evens = numbers.Where(n => n % 2 == 0).ToList();
            
            foreach (var n in evens)
                Console.WriteLine(n);

            List<string> names = new List<string> { "Nishant", "Aman", "Neha", "Nitin" };

            var nNames = names.Where(name => name.StartsWith("N"));

            Console.WriteLine("Checking DataTypes using object.GetType(): ");
            // use Object.GetType().Name to get the Direct DataType Name
            Console.WriteLine("DataType of numbers: " + numbers.GetType().Name);
            Console.WriteLine("DataType of evens: " + evens.GetType().Name);
            Console.WriteLine("DataType of nNames: " + nNames.GetType().Name);

            foreach(var n in nNames)
                Console.WriteLine(n);

        }
    }
}
