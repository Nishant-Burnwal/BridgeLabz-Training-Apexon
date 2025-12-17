using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomImplementation.ReviseConcepts
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d) 
        {
            data = d;
        }
    }

    class SingleLinkedList
    {
        public Node head;

        public void AddFirst(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;     
        }
    }
    internal class SinglyLinkedList
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinked = new SingleLinkedList();
            singleLinked.AddFirst(1);
            singleLinked.AddFirst(1);
            singleLinked.AddFirst(1);
            singleLinked.AddFirst(1);

            Console.WriteLine(singleLinked);
        }
    }
}
