using System;
using System.Collections.Generic; // must use this in Generic Collections
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class DictionariesTypes
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> students = new Dictionary<int, string>();
            students.Add(101, "Nishant");
            students.Add(102, "Amit");

            Console.WriteLine(students[101]);
            students[103] = "Added 103"; // "Added 103" if 103 not exist else updated 
            // check if key 102 exists
            if (students.ContainsKey(102))
                Console.WriteLine(students[102]);

            foreach (var kv in students)
                Console.WriteLine($"{kv.Key}: {kv.Value}");

        }
    }
}
