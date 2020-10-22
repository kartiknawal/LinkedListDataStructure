using System;

namespace LinkedListDataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Program!");
            LinkedList list = new LinkedList();
            list.AddNode(56);
            list.AddNode(30);
            list.AddNode(70);
            list.Display();
        }
    }
}
