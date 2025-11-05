// Salim Mansuri
// Course: CTEC 135
// Assignment: Module 5 - Task 2 (Stacks and Queues)
// Date: 11/05/2024
// Practice arrays and generic List<T>; initialize/print/update per instructions.

using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main()
        {
            #region Stack
            Console.WriteLine("--- STACK DEMO ---");

            Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

            Console.WriteLine("Stack members:");
            foreach (int number in stack)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.WriteLine($"\nPeek at top member in stack: {stack.Peek()}");

            Console.WriteLine("\nPopping elements from stack:");
            while (stack.Count > 0)
                Console.Write($"{stack.Pop()} ");
            Console.WriteLine();
            #endregion

            #region Queue
            Console.WriteLine("\n--- QUEUE DEMO ---");

            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= 5; i++)
                queue.Enqueue(i);

            Console.WriteLine("Queue members:");
            foreach (int number in queue)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.WriteLine($"\nPeek at front member in queue: {queue.Peek()}");

            Console.WriteLine("\nDequeuing elements from queue:");
            while (queue.Count > 0)
                Console.Write($"{queue.Dequeue()} ");
            Console.WriteLine();
            #endregion
        }
    }
}
