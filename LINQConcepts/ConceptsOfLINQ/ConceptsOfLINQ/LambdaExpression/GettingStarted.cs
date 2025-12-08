using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfLINQ.LambdaExpression
{
    // (parameter) => expression
    // A lambda expression is just a short function, written in a compact way.

    internal class GettingStarted
    {
        //without lambda
        static int SquareOfX(int x)
        {
            return x * x;
        }

        static void Main(String[] args)
        {
            Console.WriteLine(SquareOfX(5));
            // With Lambda
            Func<int, int> Square = x => x * x;

            Console.WriteLine(Square(10));
        }
    }
}
