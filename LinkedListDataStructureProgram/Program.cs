using System;

namespace LinkedListDataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Program!");
            LinkedList list1 = new LinkedList();
            list1.AddNode(56);
            list1.AddNode(30);
            list1.AddNode(70);
            list1.Display();
            Console.WriteLine("\n- - - - - - - - - -");
            LinkedList list2 = new LinkedList();
            list2.AddNode(70);
            list2.AddBefore(30);
            list2.AddBefore(56);
            list2.Display();
            Console.WriteLine("\n- - - - - - - - - -");
            LinkedList list3 = new LinkedList();
            list3.AddNode(56);
            list3.AppendNode(30);
            list3.AppendNode(70);
            list3.Display();
        }
    }
}
