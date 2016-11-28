using System;
using System.Collections.Generic;

namespace Day15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Stack and Queue

            StackClass stackClass = new StackClass();
            stackClass.StackDemo();

            QueueClass queueClass = new QueueClass();
            queueClass.QueueDemo();

            #endregion Stack and Queue
        }
    }

    internal class StackClass
    {
        public void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            // Insertion
            stack.Push("Book One");
            stack.Push("Book Two");
            stack.Push("Book Three");
            stack.Push("Book Four");

            Console.WriteLine("Go through the sequence of placed books.");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Removal
            string removedOne = stack.Pop();
            string removedTwo = stack.Pop();
            Console.WriteLine("Removed books are {0}, {1}", removedOne, removedTwo);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            string topBook = stack.Peek();
            Console.WriteLine("Current top element {0}", topBook);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class QueueClass
    {
        public void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            // Adding
            queue.Enqueue("Line one");
            queue.Enqueue("Line two");
            queue.Enqueue("Line three");
            queue.Enqueue("Line four");

            Console.WriteLine("Sequeuence of line : ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removal
            string firstLine = queue.Dequeue();
            string secondLine = queue.Dequeue();
            Console.WriteLine("Removed lines are {0}, {1}", firstLine, secondLine);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            string firstOne = queue.Peek();
            Console.WriteLine("First one in line {0}", firstOne);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}