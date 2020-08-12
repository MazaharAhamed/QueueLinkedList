using System;
using System.Xml;

namespace QueueLinkedList
{
    class QueueL
    {
        private Node front;
        private Node rear;

        public QueueL()
        {
            front = null;
            rear = null;
        }

        public int Size()
        {
            int s = 0;
            Node p = front;
            while(p!=null)
            {
                s++;
                p = p.link;
            }
            return s;
        }

        public void Insert(int x)
        {
            Node temp = new Node(x);

            if (front == null)                        /*If Queue is Null*/
                front = temp;
            else
                rear.link = temp;
            rear = temp;
        }

        public int Delete()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            x = front.info;
            front = front.link;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return front.info;
        }

        public bool isEmpty()
        {
            return (front == null);
        }

        public void Display()
        {
            if (isEmpty())
                Console.WriteLine("Queue is Empty");
            Console.WriteLine("Queue is");
            Node p = front;
            while(p!=null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
