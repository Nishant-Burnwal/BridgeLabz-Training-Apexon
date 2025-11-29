using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArrayListConcepts
{
    internal class PropertiesOfArrayList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("ArrayList");
            al.Add("is");
            al.Add(1);
            al.Add("dynamically");
            al.Add("typed");
            Console.WriteLine(al.Capacity); // 8
            Console.WriteLine(al.Count); //5
            Console.WriteLine(al.IsFixedSize); // False
            Console.WriteLine(al.IsReadOnly); // False
            Console.WriteLine(al.IsSynchronized); // False
        }
    }
}
