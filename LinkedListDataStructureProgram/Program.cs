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
            Console.WriteLine("\n- - - - - - - - - -");
            LinkedList list5 = new LinkedList();
            list5.AddNode(56);
            list5.AddNode(30);
            list5.AddNode(70);
            list5.DeleteFirstElement();
            list5.Display();
            Console.WriteLine("\n- - - - - - - - - -");
            LinkedList list6 = new LinkedList();
            list6.AddNode(56);
            list6.AddNode(30);
            list6.AddNode(70);
            list6.DeleteLastElement();
            list6.Display();
            Console.WriteLine("\n- - - - - - - - - -");
            LinkedList list7 = new LinkedList();
            list7.AddNode(56);
            list7.AddNode(30);
            list7.AddNode(70);
            list7.SearchNode(30);
            list7.Display();

            list7.InsertAfterNode(40, 30);
            Console.WriteLine("\n");
            list7.Display();

            list7.DeleteNodeOfKey(40);
            list7.Size();
            list7.Display();

            Console.WriteLine("\n- - - - - - - - - -");
            LinkedList list8 = new LinkedList();
            list8.SortingWhileAdd(56);
            list8.SortingWhileAdd(30);
            list8.SortingWhileAdd(40);
            list8.SortingWhileAdd(70);
            list8.SortingWhileAdd(64);
            list8.SortingWhileAdd(20);
            list8.SortingWhileAdd(109);
            list8.Display();

        }
    }
}
