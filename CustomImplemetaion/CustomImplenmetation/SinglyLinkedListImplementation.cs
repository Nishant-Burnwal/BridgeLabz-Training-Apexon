using System;

namespace CustomImplementation.CustomImplementation
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    class MySinglyLinkedList
    {
        Node head;

        // 1. Insert at Beginning
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        // 2. Insert at End
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }

        // 3. Delete a node by value
        public void Remove(int data)
        {
            if (head == null) return;

            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null && current.next.data != data)
            {
                current = current.next;
            }

            if (current.next != null)
            {
                current.next = current.next.next;
            }
        }

        // 4. Search
        public bool Contains(int data)
        {
            Node current = head;

            while (current != null)
            {
                if (current.data == data)
                    return true;

                current = current.next;
            }
            return false;
        }

        // 5. Display list
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " -> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }

        // 6. Count Nodes
        public int Count()
        {
            int count = 0;
            Node current = head;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }

        // 7. Reverse List
        public void Reverse()
        {
            Node prev = null;
            Node current = head;

            while (current != null)
            {
                Node nextTemp = current.next;
                current.next = prev;
                prev = current;
                current = nextTemp;
            }

            head = prev;
        }
    }

    internal class SinglyLinkedListImplementation
    {
        static void Main(string[] args)
        {
            MySinglyLinkedList list = new MySinglyLinkedList();

            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            list.AddLast(5);

            list.Print();        // 30 -> 20 -> 10 -> 5 -> null
            list.Remove(20);
            list.Print();        // 30 -> 10 -> 5 -> null

            Console.WriteLine(list.Contains(10)); // True
            Console.WriteLine(list.Count());       // 3

            list.Reverse();
            list.Print();        // 5 -> 10 -> 30 -> null
        }
    }
}
