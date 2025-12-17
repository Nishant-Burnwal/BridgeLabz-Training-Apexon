using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomImplementation.CustomImplenmetation
{
    class MyQueue
    {
        List<int> list = new List<int>();
        public void Enqueue(int n)
        {
            list.Add(n);
        }

        public int Dequeue()
        {
            int first = list[0];
            list.RemoveAt(0);
            return first;
        }
    }
    
    internal class QueueImplementation
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);


            Console.WriteLine(myQueue.Dequeue()); // remove 10 and prints too
            Console.WriteLine(myQueue.Dequeue()); // remove 20 and prints too
            Console.WriteLine(myQueue.Dequeue()); // similarly
            Console.WriteLine(myQueue.Dequeue()); // ""
            Console.WriteLine(myQueue.Dequeue()); // ""
        }
    }
}
