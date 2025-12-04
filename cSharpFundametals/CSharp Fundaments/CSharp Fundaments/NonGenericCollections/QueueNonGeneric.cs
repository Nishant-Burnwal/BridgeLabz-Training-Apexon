using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.NonGenericCollections
{
    internal class QueueNonGeneric
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Task 1");
            q.Enqueue(1);

            Console.WriteLine(q.Dequeue()); // Task1
            Console.WriteLine(q.Peek());    // 1

            /*
             * Last-In-First-Out
               Replaced by Stack<T>
             */
        }
    }
}
