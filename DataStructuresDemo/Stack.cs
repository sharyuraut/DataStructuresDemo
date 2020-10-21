using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value + " Pushed to stack");
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is already Empty!");
                return;
            }
            Console.WriteLine(this.top.data + " is on the top");
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is already Empty!");
            }
            Console.WriteLine("Element popped out is: " + this.top.data);
            this.top = this.top.next;
        }
    }
}
