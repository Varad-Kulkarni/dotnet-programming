using System.Collections.Generic;

namespace csharp_programming {
    internal class Program {
        static void Main() {
            // Creating list
            LinkedList<int> list = new LinkedList<int>();

            // Adding items
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Accessing items
            Console.WriteLine(list.First.Next);

            // Removing items
            list.Remove(2);
        }
    }
}

/*
 * In C#, the LinkedList<T> class is a generic collection class that is used to
 * store a collection of elements of the same data type T.
 * 
 * LinkedList<T> is implemented as a doubly linked list.
 * 
 * Each node in the list contains an element and references to
 * the previous and next nodes in the list. This makes inserting
 * or removing elements in the middle of the list fast, as it
 * only requires updating the references of adjacent nodes.
 * 
 * However, accessing elements by index is slower, as the list
 * must be traversed from the beginning or end to reach the
 * desired element.
 * 
 * In summary, List<T> is generally faster than LinkedList<T> for
 * accessing elements by index and performing operations at 
 * the end of the list, while LinkedList<T> is faster for inserting
 * or removing elements in the middle of the list.
 */