using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Linked List");
            LinkedList list = new LinkedList();
            list.Add(11);
            list.Add(08);
            list.Add(97);
            list.Display();

            Console.WriteLine("----------------");

            Stack stack = new Stack();
            stack.Push(2);
            stack.Push(5);
            stack.Push(8);
            stack.Push(1);
            stack.Display();
            Console.WriteLine("----------------");

        }
    }
}
