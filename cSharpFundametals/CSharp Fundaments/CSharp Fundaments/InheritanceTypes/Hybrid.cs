using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Hybrid Inheritance (Combination of multiple types)

 * C# achieves hybrid inheritance using interfaces + classes.
 *     A
      / \
     B   C
      \ /
       D

 */
namespace CSharp_Fundaments.InheritanceTypes
{
    class Apple
    {
        public void AppleSuper() => Console.WriteLine("Apple Super Method");
    }
    class Ball : Apple
    {
        public void BallInherited() => Console.WriteLine("Ball Inherited Method");
    }

    class Coconut : Apple
    {
        public void CoconutInherited() => Console.WriteLine("Coconut Inherited");
    }

    interface ITest
    {
        void Test();
    }

    class Diamond : Ball, ITest
    {
        public void Test() => Console.WriteLine("Test Method");
    }
    internal class Hybrid
    {
        static void Main(string[] args)
        {
            Diamond diamond = new Diamond();
            diamond.AppleSuper();
            diamond.Test();

        }
    }
}
