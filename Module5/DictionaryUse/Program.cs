// Salim Mansuri
// Course: CTEC 135
// Assignment: Module 5 - Task 3 Dictionary
// Date: 11/05/2024
// Practice arrays and generic List<T>; initialize/print/update per instructions.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize a dictionary with three entries
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" }
        };

        // Use the Add method to add (99, "ninety-nine")
        dictionary.Add(99, "ninety-nine");

        // Print out each key and value in the dictionary using KeyValuePair<>
        Console.WriteLine("Dictionary entries using KeyValuePair:");
        foreach (KeyValuePair<int, string> entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // Print out each key and value in the dictionary using var
        Console.WriteLine("\nDictionary entries using var:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // Reassign the value of key 99 to "99" using indexing notation
        dictionary[99] = "99";

        // Print the value of key 99 using indexing notation
        Console.WriteLine($"\nValue of key 99: {dictionary[99]}");

        // Remove the entry with key 2
        dictionary.Remove(2);

        // Print the updated dictionary
        Console.WriteLine("\nUpdated dictionary:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}