using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        int size = 0;
        public class Node
        {
            public object Content;
            public Node next;
        }
        private Node start;
        public void CreateQueue()
        {
            start = null;
        }
        public bool IsEmpty()
        {
            return start == null;
        }
        public void Enqueue(object content)
        {
            Node current = start;
            while (current != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.Content = content;
            current.next = newNode;
            size++;
        }
        public object Dequeue()
        {
            if (IsEmpty())
            {
                return null;
            }
            object dequeued = start.Content;
            start = start.next;
            size--;
            return dequeued;
        }
        public void DestroyQueue()
        {
            while (start != null)
            {
                start = start.next;
            }
            size = 0;
        }
        public int Length()
        {
            return size;
        }
        public object Peek()
        {
            return start.Content;
        }
    }
}