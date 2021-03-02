using System;
using System.Collections.Generic;

namespace StacksAndQueuesDay16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stacks and queue");
            LinkedListStack list = new LinkedListStack();
 
            Console.WriteLine("Push Stack");
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();

            
            list.peek();
            list.Pop();
            Console.ReadLine();
        }
    }
}
