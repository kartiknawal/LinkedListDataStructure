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

    }
}
