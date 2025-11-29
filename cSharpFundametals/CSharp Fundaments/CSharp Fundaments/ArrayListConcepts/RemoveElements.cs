using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArrayListConcepts
{
    internal class RemoveElements
    {
        // Create ArrayList
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add("C");
            myList.Add("C#");
            myList.Add("Python");
            myList.Add("Java");
            myList.Add("C#");
            myList.Add("JS");

            Console.WriteLine("The Array int the ArrayList are: ");
            foreach (String str in myList) // We have used String instead of var as we already know the all data types added is string
                Console.WriteLine(str);

            // Removing the first occurrence of C#
            myList.Remove("C#");
            // Removing HTML
            myList.Remove("HTML"); // As HTML is not present it will return the list as it sis
            Console.WriteLine("The element in the ArrayList are: ");

            foreach(String str in myList)
                Console.WriteLine(str);
            /*
             * Note:
                1. This method performs a linear search, therefore, this method is an O(n) operation, where n is Count.
                2. If the ArrayList does not contain the specified object, the ArrayList remains unchanged. No exception is thrown
             */
        }
    }
}
