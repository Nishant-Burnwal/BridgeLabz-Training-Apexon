using CustomImplementation.CustomImplenmetation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomImplementation.WorkingWithNode
{
    /* Docs: 
     * A node is a small box that holds data and a link to the next box.

        Think of a train 

        Each coach = a node

        Each coach has:

        1. Value (passengers) → the data

        2. Connector to the next coach → the link / reference

        So in a linked list:

        1. A node stores one piece of information

        2. And knows where the next node is
     */
    internal class WhatIsNode
    {
        static void Main(string[] args)
        {
            Node first = new Node(10); 
            Node second = new Node(20);
            Node third = new Node(30);

            first.next = second;
            second.next = third;

            // this creates
            // [10] → [20] → [30] → null

            // Access Data
            Console.WriteLine(first.data);
            Console.WriteLine(first.next.data);
            Console.WriteLine(first.next.next.data);
            Console.WriteLine(second.next.data);
        }
    }
}
