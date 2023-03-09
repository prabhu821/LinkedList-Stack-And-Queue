﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Stack_And_Queue;

public class LinkedListQueue
{
    //uc3-QUEUE CREATED
    Node head = null;
    public void Enqueue(int data)
    {
        Node node = new Node(data);
        if (head == null)
        {
            head = node;
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
        Console.WriteLine("{0} is inserted into Queue", node.data);
    }

    //uc4-DEQUEUE
    public void Dequeue()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is Empty.So Deletion is not Possible");
            return;
        }
        else
        {
            this.head = this.head.next;
        }
        Console.WriteLine("After Dequeue,");
        Display();
    }

    //uc3-DISPLAY
    public void Display()
    {
        Node temp = this.head;
        if (temp == null)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.WriteLine("Queue is as:");
        while (temp != null)
        {
            Console.WriteLine(temp.data + " ");
            temp = temp.next;
        }
    }
}
