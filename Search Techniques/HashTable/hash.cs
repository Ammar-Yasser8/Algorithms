/*
Algorithm: Hash Table (Chaining)
Time Complexity:
  Best: O(1) for insert/find
  Average: O(1) for insert/find
  Worst: O(n) for insert/find
Space Complexity: O(n + b)
Example:
  Input: keys = [21, 22, 32] into 10 buckets
  Output: bucket 1 -> 21, bucket 2 -> 22, 32
LeetCode:
  - https://leetcode.com/problems/two-sum/
  - https://leetcode.com/problems/group-anagrams/
  - https://leetcode.com/problems/contains-duplicate/
*/

namespace HashTable
{
    public class Hash
    {
        int buckets;
        List<int>[] table;

        public Hash(int V)
        {
            buckets = V;
            table = new List<int>[buckets];
            for (int i = 0; i < buckets; i++)
            {
                table[i] = new List<int>();
            }
        }

        public int HashFunction(int key)
        {
            return key % buckets;
        }

        public void Insert(int key)
        {
            int index = HashFunction(key);
            table[index].Add(key);
        }

        public void displayHash()
        {
            for (int i = 0; i < buckets; i++)
            {
                Console.Write(i + " --> ");
                foreach (int x in table[i])
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
