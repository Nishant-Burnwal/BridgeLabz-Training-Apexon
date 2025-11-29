using System;
using System.Collections; //used in creating ArrayList 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArrayListConcepts
{
    /*
     * ArrayList is a powerful feature of C# language.
     * It is the non-generic type of collection which is
     * defined in System.Collections namespace.
     * It is used to create a dynamic array, meaning the size 
     * of the array increases or decreases automatically 
     * according to the requirements of your program. 
     * There is no need to specify the size of an ArrayList.
     */

    internal class BasicsOfArrayList
    {
        static void Main(string[] args)
        {
            // Creating ArrayList
            ArrayList l= new ArrayList();

            // You can add elements like this:
            l.Add(10);
            l.Add("Hello");
            l.Add(3.14);

            // Displaying elements
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
