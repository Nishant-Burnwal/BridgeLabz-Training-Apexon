using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A -> B -> C
namespace CSharp_Fundaments.InheritanceTypes
{
    class A
    {
        public void AMethod() => Console.WriteLine("A Method");
    }

    class B: A
        {
       public void BMethod() => Console.WriteLine("B Method");
        }

    class C: B
    {
        public void CMethod() => Console.WriteLine("C Method");
    }
    internal class MultiLevel
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            // A
            Console.WriteLine("A object Creation: ");
            a.AMethod();
            // B
            Console.WriteLine("B object Creation: ");
            b.AMethod();
            b.BMethod();
            // C
            Console.WriteLine("C object Creation: ");
            c.AMethod();
            c.BMethod();
            c.CMethod();

        }
    }
}
