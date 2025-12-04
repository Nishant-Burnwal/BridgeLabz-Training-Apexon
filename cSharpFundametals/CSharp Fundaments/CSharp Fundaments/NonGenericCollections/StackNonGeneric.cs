using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.NonGenericCollections
{
    internal class StackNonGeneric
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(100);
            st.Push("Hello");

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
        }
    }
}
