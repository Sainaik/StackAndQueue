using System;

namespace StackNQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Operations!");

            Console.WriteLine("Stack Operations!");

            Stack stack = new Stack();

            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();

            stack.Pop();
            stack.Peek();

            stack.Display();

            Console.WriteLine("\nQueue Operations!");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
