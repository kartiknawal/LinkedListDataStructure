using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructureProgram
{
    public class LinkedList
    {
        public Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the list", node.data);
        }

    
        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

        public void AddBefore(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public Node DeleteFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }
            head = head.next;
            return head;
        }
        public Node DeleteLastElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty list");
                return null;
            }

            Node temp = this.head;

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            temp.next = null;
            
            return temp;
        }
        public Node SearchNode(int data)
        {

            Node foundNode = new Node(data);
            Node temp = head;
            while (temp.next != null)
            {
                if (foundNode.data == temp.data)
                {
                    Console.WriteLine("Node with value {0} found", foundNode.data);
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }
        public Node InsertAfterNode(int insertedValue, int previousValue)
        {
            Node temp = SearchNode(previousValue);
            if (temp != null)
            {
                Node node = new Node(insertedValue);
                node.next = temp.next;
                temp.next = node;
                Console.Write("Node {0} has been inserted after {1}", insertedValue, previousValue);
                return node;
            }
            else
            {
                Console.Write("Node could not be inserted");
                return null;
            }
        }
        public void DeleteNodeOfKey(int data)
        {
            Node key = SearchNode(data);
            Node temp = head;
            if (temp == null)
            {
                Console.Write("Node could not be found");
                return;
            }
            else
            {
                while (temp.next.data != key.data)
                {
                    temp = temp.next;
                }
                temp.next = key.next;
                key.next = null;
                Console.WriteLine("Data with value {0} has been deleted ", key.data);
            }
        }
        public int Size()
        {
            int size = 1;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            while (temp.next != null)
            {
                size++;
                temp = temp.next;
            }
            Console.WriteLine("Size of the list is {0}", size);
            return size;
        }
        public void SortingWhileAdd(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                if (head.data > data)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null && temp.next.data < data)
                    {
                        temp = temp.next;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
            }
        }
    }
}
