using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class StackLIFO
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(100);
            stack.Push(100);
            stack.Push(200);

            foreach (var item in stack) {
            Console.WriteLine(item); //200->100->100->100
        }

        Console.WriteLine(stack.Pop());// 200
            Console.WriteLine(stack.Pop());// 100
            Console.WriteLine(stack.Pop()); // 100
            Console.WriteLine(stack.Pop()); // 100

        }
    }
}
