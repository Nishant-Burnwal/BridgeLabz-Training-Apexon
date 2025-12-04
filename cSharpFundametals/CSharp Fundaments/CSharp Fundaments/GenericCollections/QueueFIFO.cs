using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    // Use Case: First-In-First-Out processing (like customer queue).
    internal class QueueFIFO
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Task1");
            queue.Enqueue("Task2");

            Console.WriteLine(queue.Dequeue()); // Task1

            Console.WriteLine(queue.Peek());    // Task2 (not removed)

        }
    }
}
