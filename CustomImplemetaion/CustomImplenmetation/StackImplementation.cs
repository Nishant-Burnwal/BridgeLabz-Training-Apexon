using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomImplementation.CustomImplementation
{
    class MyStack : IEnumerable<int>
    {
        private List<int> list = new List<int>();

        public void Push(int n)
        {
            list.Add(n);
        }

        public int Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            int last = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return last;
        }

        public int Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return list[list.Count - 1];
        }

        // IEnumerable implementation
        public IEnumerator<int> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class StackImplementation
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            Console.WriteLine("Peek: " + myStack.Peek());
            Console.WriteLine("Popped: " + myStack.Pop());

            Console.WriteLine("Stack contents:");
            foreach (int x in myStack)
            {
                Console.WriteLine(x);
            }
        }
    }
}
