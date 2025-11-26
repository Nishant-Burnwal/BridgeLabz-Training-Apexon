using System;

namespace CSharp_Fundaments.OOPS_Concepts
{
    class Calculator1
    {
        // Method Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    internal class PolymorphismCompileTime
    {
        static void Main(string[] args)
        {
            Calculator1 calc = new Calculator1();

            Console.WriteLine(calc.Add(2, 3));          // calls int Add
            Console.WriteLine(calc.Add(2.5, 3.1));      // calls double Add
            Console.WriteLine(calc.Add(1, 2, 3));       // calls int Add (3-parameters)

            Console.ReadLine(); // Prevent console from closing immediately
        }
    }
}
