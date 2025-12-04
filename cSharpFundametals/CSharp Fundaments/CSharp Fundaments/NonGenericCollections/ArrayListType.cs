using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.NonGenericCollections
{
    internal class ArrayListType
    {
        static void Main(string[] args)
        {
            // ArrayList — Resizable Array (Stores Any Type)
            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add("Nishant");
            list.Add(20.5);

            list.Remove(10);

            foreach (var item in list)
                Console.WriteLine(item);

            /*
             *  Stores different data types
                Low performance because of boxing/unboxing
                Replaced by List<T> (generic)
             */
        }
    }
}
