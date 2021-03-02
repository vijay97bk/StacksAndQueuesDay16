using System;

namespace StacksAndQueuesDay16
{
    public class LinkedList
    {
        Node top;
        public LinkedList()
        {
            this.top = null;
        }
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine($"New Node added to the stack: " + newData);
        }
        public void Display()
        {
            if (top == null)
            {
                Console.Write("stack is empty");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}