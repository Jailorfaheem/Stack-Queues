using System;

namespace QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object stack class
            QueueLinkedList queue = new QueueLinkedList();
            //calling Enquue method
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            //calling display method
            queue.Display();
            Console.ReadLine();

        }
    }
}