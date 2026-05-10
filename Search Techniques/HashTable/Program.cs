/*
Algorithm: Hash Table (Chaining)
Time Complexity:
  Best: O(1) for insert/find
  Average: O(1) for insert/find
  Worst: O(n) for insert/find
Space Complexity: O(n + b)
Example:
  Input: keys = [21, 22, 32, 42] into 10 buckets
  Output: bucket 1 -> 21, bucket 2 -> 22, 32, 42
LeetCode:
  - https://leetcode.com/problems/two-sum/
  - https://leetcode.com/problems/group-anagrams/
  - https://leetcode.com/problems/contains-duplicate/
*/

//        HashTable<TKey, TValue> is a type of data structure that stores key-value pairs.
//        It allows for efficient retrieval, insertion, and deletion of values based on their associated keys.
//*/

//// to get O(1) average time complexity for lookups, insertions, and deletions.


//// Create a new hash table.
//using System.Collections;

//Hashtable openWith = new Hashtable();
//// Add some key/value pairs to the hash table.
//// No Duplicate keys, but some of the values are duplicates.
//openWith.Add("txt", "notepad.exe");
//openWith.Add("bmp", "paint.exe");
//openWith.Add("dib", "paint.exe");
//openWith.Add("rtf", "wordpad.exe");
//// The following line would throw an exception because the key "txt" already exists.
//// openWith.Add("txt", "winword.exe");
//// The following line would throw an exception because the key is null.
//// openWith.Add(null, "value");
//// The following line would throw an exception because the value is null.
//// openWith.Add("key", null);
//// Display the value associated with the key "rtf".
//Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);


// Build a HashTable algorithm from scratch for 10 key-value pairs
//{21.22.32.42}

//21 % 10 = 1 -> index 1
//22 % 10 = 2 -> index 2
//32 % 10 = 2 -> index 2 (collision)
//42 % 10 = 2 -> index 2 (collision)


//  I will make a Hash Class and it`s methods to handle collisions using chaining.

using HashTable;

int[] a = { 21, 22, 32, 42, 53, 64, 75, 86, 97, 108 };
int n = a.Length;
Hash h = new Hash(10);
for (int i = 0; i < n; i++)
{
    h.Insert(a[i]);
}

h.displayHash();
