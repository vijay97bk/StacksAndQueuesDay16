using System;
using System.Collections;

namespace StacksAndQueuesDay16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stacks and queue");
            LinkedListStack list = new LinkedListStack();
            //UC1
            Console.WriteLine("Push Stack");
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();

            //UC2
            list.peek();
            list.Pop();

            //UC3
            Console.WriteLine("Queue Qperation");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.ReadLine();
        }
    }
}
