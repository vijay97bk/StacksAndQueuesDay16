using System;
using System.Collections.Generic;

namespace StacksAndQueuesDay16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stacks and queue");
            LinkedList list = new LinkedList();
            //UC-1
            Console.WriteLine("Pushing nodes in stack");
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
