using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A -> B
 */

namespace CSharp_Fundaments.InheritanceTypes
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent Show");
        }
    }

    class Child : Parent
    {
        public void Display()
        {
            Console.WriteLine("Child Display");
        }
    }

    internal class SingleInheritance
    {
       static void Main(string[] args)
       {
            Parent parent = new Parent();
            parent.show(); // Parent Show
            Child child = new Child();
            child.show(); // Parent Show
            child.Display(); // Child Display
            
       }
    }
}
