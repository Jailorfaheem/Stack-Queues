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
            queue.Enqueve(56);
            queue.Enqueve(30);
            queue.Enqueve(70);
            //calling display method
            queue.Display();
            //calling Dequeue method
            queue.Dequeue();
            queue.Display();
            Console.ReadLine();

        }
    }
}