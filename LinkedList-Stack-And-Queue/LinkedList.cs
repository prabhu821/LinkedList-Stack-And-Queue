using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Stack_And_Queue;

public class LinkedList
{
    //UC1-Create Linked List
    public Node head;
    public void Add(int data)
    {
        Node node = new Node(data);
        if (this.head == null)
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
        Console.WriteLine("{0} inserted into linked list", node.data);
    }

    //UC2-Display List
    public void Display()
    {
        Node temp = this.head;
        if (temp == null)
        {
            Console.WriteLine("Linked List is empty");
            return;
        }
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    //ADD IN REVERSE ORDER
    public void AddInReverseOrder(int data)
    {
        Node newNode = new Node(data);
        if (this.head == null)
        {
            this.head = newNode;
        }
        else
        {
            Node temp = this.head;
            head = newNode;
            head.next = temp;
        }
    }
}
