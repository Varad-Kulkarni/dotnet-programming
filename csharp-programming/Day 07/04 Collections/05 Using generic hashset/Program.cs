using System.Collections.Generic;

namespace csharp_programming {
    internal class Program {
        static void Main() {
            // Creating set
            HashSet<int> set = new HashSet<int>();

            // Adding items
            set.Add(1);
            set.Add(2);
            set.Add(3);

            // Accessing items
            Console.WriteLine(set.Contains(2));

            // Removing items
            set.Remove(2);
        }
    }
}

/*
 * The HashSet<T> class in C# uses a hash table as its underlying
 * data structure to store the elements.
 * 
 * In the case of a HashSet<T>, the hash function takes the value of type T
 * as input and produces a hash code that is used to determine where the
 * element should be stored in the hash table. The hash code is used to
 * calculate the index in the array where the element is stored,
 * and if there is already an element stored at that index,
 * the HashSet<T> class uses an algorithm called "chaining" to store the element
 * in a linked set at that index.
 *  * When an element is added to a HashSet<T>, the class checks if there is already
 * an element with the same hash code in the hash table. If there is not, the element
 * is added to the hash table at the appropriate index. If there is already an
 * element with the same hash code, the HashSet<T> class checks if the two elements
 * are equal using the Equals method. If the elements are equal, the new element is
 * not added to the hash set. If the elements are not equal, the HashSet<T> class uses
 * chaining to add the new element to the linked set at the appropriate index.
 * * When an element is removed from a HashSet<T>, the class uses the hash code of
 * the element to find the index in the array where the element is stored. If there
 * is a linked set at that index, the HashSet<T> class traverses the linked set to
 * find the element to remove.
 * * Overall, the hash table data structure used by HashSet<T> provides efficient lookup,
 * insertion, and deletion of elements, with an average time complexity of O(1) for 
 * these operations. However, the actual time complexity can depend on the quality
 * of the hash function and the distribution of the hash codes of the elements.
 */