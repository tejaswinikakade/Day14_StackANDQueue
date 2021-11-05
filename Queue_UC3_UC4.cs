using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue_UC3_UC4
    {
        NodeQueue head, tail;

        public void Queue()
        {
            this.head = this.tail = null;
        }

        //UC3 to add a queue
        public void enqueue(int key)
        {


            NodeQueue temp = new NodeQueue(key);


            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }


            this.tail.next = temp;
            this.tail = temp;

        }

        //UC4 to dequeue

        public void dequeue()
        {

            if (this.head == null)
                return;


            NodeQueue temp = this.head;
            this.head = this.head.next;


            if (this.head == null)
                this.tail = null;
            Console.WriteLine("Head is removed");
        }

        internal void PrintQueue()
        {
            NodeQueue temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }


        }

    }
}