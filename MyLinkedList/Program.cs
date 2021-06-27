using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    //Нода элемент списка
    class Node
    {
        public Node next;
        public int value;

        public Node(int a)
        {
            next = null;
            value = a;
        }
        public void Display()
        {
            Console.Write(value+"-->");
            if(next!=null)
            {
                next.Display();
            }
        }

        public void AddSorted(int data)
        {
            if(next==null)
            {
                next = new Node(data);
            }
            else if(data<next.value)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
                next = new Node(data);
            else
                next.AddToEnd(data);
        }

    }

    class myLinkedList
    {
        public Node head;
        public int count { get; }

        public void AddSorted(int data)
        {
            if(head==null)
            {
                head = new Node(data);
            }
            else if(data< head.value)
            {
                AddToBegining(data);
            }
            else
            {
                head.AddSorted(data);
            }
        }
        public void AddToEnd(int n)
        {
            if (head == null) head = new Node(n);
            else
                head.AddToEnd(n);

        }

        public void AddToBegining(int n)
        {
            if(head==null)
            {
                head = new Node(n);
            }
            else
            {
                var temp = head;
                head = new Node(n);
                head.next = temp;
            }
        }

        public void Print()
        {
            head.Display();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myLinkedList list = new myLinkedList();
            //list.AddToEnd(5);
            //list.AddToEnd(6);
            //list.AddToEnd(7);
            //Console.WriteLine("Out node list");
            //list.Print();
            //Console.WriteLine();
            //list.AddToBegining(11);
            //list.AddToEnd(42);
            list.AddSorted(91);
            list.AddSorted(11);
            list.AddSorted(21);
            list.AddSorted(61);
            list.AddSorted(31);
            list.AddSorted(1);

            list.Print();
            Console.ReadLine();


        }
    }
}
