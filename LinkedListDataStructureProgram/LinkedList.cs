﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructureProgram
{
    class LinkedList
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

        public void InsertInBetween(int data, int position)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            Node temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;

        }
    }
}
