using System;
namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1 Creat Stack
            Console.WriteLine("-----UC1-----");
            Stack_UC1_UC2 stack = new Stack_UC1_UC2();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");


            #region UC2 peek and pop till empty
            Console.WriteLine("-----UC2-----");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            stack.Peek();
            stack.Pop();
            stack.EmptyStack();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");


            /*#region UC3 Enqueue- Creat queue
            Console.WriteLine("-----UC3-----");
            Queue_UC3_UC4 queue = new Queue_UC3_UC4();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            #endregion
            Console.WriteLine("\n----------------------------------------------------");

            #region UC4 Dequeue List
            Console.WriteLine("-----UC4-----");
            Console.WriteLine("enqued list:");
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            Console.WriteLine("\n------------");
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            #endregion*/
            Console.ReadKey();
        }
    }
}