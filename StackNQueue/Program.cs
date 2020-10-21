using System;

namespace StackNQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Operations!");

            Stack stack = new Stack();

            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
        }
    }
}
