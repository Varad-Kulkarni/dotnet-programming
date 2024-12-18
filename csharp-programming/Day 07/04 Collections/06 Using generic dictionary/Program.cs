﻿using System.Collections.Generic;

namespace csharp_programming {
    internal class Program {
        static void Main() {
            // Creating dict
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Adding items
            dict.Add("apple", 1);
            dict.Add("banana", 2);
            dict.Add("orange", 3);

            // Accessing items
            Console.WriteLine(dict["apple"]);

            // Updating values 
            dict["apple"] = 4;

            // Removing items
            dict.Remove("banana");
        }
    }
}

/*
 * The Dictionary<TKey, TValue> class in C# uses a hash table as its underlying
 * data structure to store the key-value pairs.
 * 
 * In the case of a Dictionary<TKey, TValue>, the hash function takes the key
 * of type TKey as input and produces a hash code that is used to determine where
 * the key-value pair should be stored in the hash table. The hash code is used
 * to calculate the index in the array where the key-value pair is stored,
 * and if there is already a key-value pair stored at that index, the
 * Dictionary<TKey, TValue> class uses an algorithm called "chaining" to store
 * the key-value pair in a linked list at that index.
 *
 ** When a key-value pair is added to a Dictionary<TKey, TValue>, the class checks if
 * there is already a key with the same hash code in the hash table. If there is not,
 * the key-value pair is added to the hash table at the appropriate index. If there
 * is already a key with the same hash code, the Dictionary<TKey, TValue> class checks
 * if the two keys are equal using the Equals method. If the keys are equal, the value
 * of the existing key-value pair is overwritten with the new value. If the keys are not
 * equal, the Dictionary<TKey, TValue> class uses chaining to add the new key-value pair
 * to the linked list at the appropriate index.
 *
 * * When a key-value pair is removed from a Dictionary<TKey, TValue>, the class uses the
 * hash code of the key to find the index in the array where the key-value pair is stored.
 * If there is a linked list at that index, the Dictionary<TKey, TValue> class traverses
 * the linked list to find the key-value pair to remove.
 *
 * * Overall, the hash table data structure used by Dictionary<TKey, TValue> provides efficient
 * lookup, insertion, and deletion of key-value pairs, with an average time complexity of 
 * O(1) for these operations. However, the actual time complexity can depend on the 
 * quality of the hash function and the distribution of the hash codes of the keys.
 */