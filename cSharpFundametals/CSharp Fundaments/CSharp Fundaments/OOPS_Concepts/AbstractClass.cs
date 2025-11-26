using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.OOPS_Concepts
{
    abstract class Shape
    {
        // abstract method
        public abstract int area();
    }

    class Square : Shape
    {
        //private data
        private int side;

        //method of square class
        public Square(int x = 5)
        {
            side = x;
        }

        public override int area()
        {
            Console.Write("Area of a Square: ");
            return (side * side);
        }
    }
    internal class AbstractClass
    {
        static void Main(string[] args)
        {
            Shape sh = new Square();

            double result = sh.area();
            Console.WriteLine("{0}", result);
        }
    }
}
