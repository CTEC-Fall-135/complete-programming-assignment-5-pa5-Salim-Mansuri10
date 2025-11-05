// Salim Mansuri
// Course: CTEC 135
// Assignment: Module 5 - Task 1 (Arrays and Lists)
// Date: 11/05/2024
// Practice arrays and generic List<T>; initialize/print/update per instructions.

using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            #region SimpleArray
            Console.WriteLine("--- Simple Array ---");

            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 11 + i;
            }

            Console.WriteLine("Array values:");
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
            #endregion

            #region List<T>
            Console.WriteLine("\n--- List<int> ---");

            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(21 + i);
            }

            Console.WriteLine("List values:");
            foreach (int value in list)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = 31 + i;
            }

            Console.WriteLine("\nUpdated List values:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
            #endregion
        }
    }
}