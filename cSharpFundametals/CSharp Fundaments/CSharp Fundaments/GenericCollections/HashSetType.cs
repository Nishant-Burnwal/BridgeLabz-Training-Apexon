using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class HashSetType
    {
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();

            uniqueNumbers.Add(10);
            uniqueNumbers.Add(11);
            uniqueNumbers.Add(11); // Duplicate, igored

            foreach (var x in uniqueNumbers)
            {
                Console.WriteLine(x); // 10 /n 11
            }
        }
    }
}
