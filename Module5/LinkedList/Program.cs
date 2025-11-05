// Salim Mansuri
// Course: CTEC 135
// Assignment: Module 5 - Task 4 Linked List
// Date: 11/05/2024
// Practice arrays and generic List<T>; initialize/print/update per instructions.

using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main()
        {
            #region Initialize
            string[] rhymeWords =
                { "Twinkle", "twinkle", "little", "star", "how", "I", "wonder", "what", "you", "are" };
            LinkedList<string> rhymeList = new LinkedList<string>(rhymeWords);
            #endregion

            #region EnumeratorTraversal
            Console.WriteLine("Rhyme using enumerator:");
            foreach (string word in rhymeList)
                Console.Write($"{word} ");
            Console.WriteLine();
            #endregion

            #region ManualWalk
            Console.WriteLine("\nRhyme by walking the linked list:");
            LinkedListNode<string> current = rhymeList.First;
            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
            Console.WriteLine();
            #endregion

            #region RemoveAdd
            LinkedListNode<string> removeNode = rhymeList.Find("how");
            if (removeNode != null) rhymeList.Remove(removeNode);

            Console.WriteLine("\nAfter removing 'how':");
            foreach (string word in rhymeList)
                Console.Write($"{word} ");
            Console.WriteLine();

            LinkedListNode<string> afterNode = rhymeList.Find("star");
            if (afterNode != null) rhymeList.AddAfter(afterNode, "how");

            Console.WriteLine("\nAfter adding 'how' back:");
            foreach (string word in rhymeList)
                Console.Write($"{word} ");
            Console.WriteLine();
            #endregion
        }
    }
}