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
        }
    }
}
