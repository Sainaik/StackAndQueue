using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueue
{
    public class Queue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
                Console.WriteLine($"{node.data} is inserted in Queue");

            }
        }

        internal void DeQueue()
        {

            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            int data = temp.data;

            Console.WriteLine(data + " is Dequeued ");

            head = temp.next;




        }

        internal void Display()
        {
            Console.WriteLine("Queue Data:");
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;

                }
            }
        }

    }
}
