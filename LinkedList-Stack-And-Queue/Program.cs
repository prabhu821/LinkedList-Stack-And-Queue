﻿namespace LinkedList_Stack_And_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList-Stack-and-Queue!");
            LinkedList list = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create Linked List \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;

                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}