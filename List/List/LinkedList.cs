using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class LinkedList
    {
        public class Node
        {
            public object Content;
            public Node Next;
        }
        private Node head;
        public LinkedList()
        {
            head = null;
        }
        public void InsertBeginning(object content)
        {
            Node newNode = new Node();
            newNode.Content = content;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        public void InsertAfter(Node after, object content)
        {
            Node current = head;
            while (current != after)
            {
                current = current.Next;
                if (current == null)
                {
                    return;
                }
            }
            Node newNode = new Node();
            newNode.Content = content;
            current.Next = newNode;
        }
        public void RemoveBeginning()
        {
            head = null;
        }
        public void RemoveAfter(Node after)
        {
            Node current = head;
            while (current != after)
            {
                current = current.Next;
                if (current == null)
                {
                    return;
                }
            }
            current = null;
        }
        public int Length()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}