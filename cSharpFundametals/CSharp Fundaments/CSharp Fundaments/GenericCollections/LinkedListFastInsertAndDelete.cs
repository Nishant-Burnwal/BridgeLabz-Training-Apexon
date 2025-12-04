using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Fundaments.GenericCollections
{
    internal class LinkedListFastInsertAndDelete
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("A");
            list.AddFirst("Start");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
