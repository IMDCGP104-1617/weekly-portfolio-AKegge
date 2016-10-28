using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        int size = 0;
        public class Node
        {
            public object Content;
            public Node Next;
        }
        private Node top;
        public bool IsEmpty()
        {
            return top == null;
        }
        public void CreateStack()
        {
            top = null;
        }
        public void Push(object content)
        {
            Node newNode = new Node();
            newNode.Content = content;
            if (top != null)
            {
                newNode.Next = top;
            }
            top = newNode;
            size++;
        }
        public object Peek()
        {
            return top;
        }
        public object Pop()
        {
            if (IsEmpty())
            {
                return null;
            }
            object poped = top.Content;
            top = top.Next;
            size--;
            return poped;
        }
        public void DestroyStack()
        {
            while (top != null)
            {
                top = top.Next;
            }
            size = 0;
        }
        public int count()
        {
            return size;
        }
    }
}