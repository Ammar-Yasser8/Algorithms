/*
Algorithm: Remove Duplicates from Sorted Array
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(1)
Example:
  Input: [1, 1, 2, 2, 3, 4, 4]
  Output: length = 4, array = [1, 2, 3, 4]
LeetCode:
  - https://leetcode.com/problems/remove-duplicates-from-sorted-array/
  - https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
  - https://leetcode.com/problems/remove-element/
*/

int[] numbers = { 1, 1, 2, 2, 3, 4, 4 };

int newLength = RemoveDuplicates(numbers);

Console.WriteLine($"New length: {newLength}");
Console.WriteLine("Array: " + string.Join(", ", numbers.Take(newLength)));

int RemoveDuplicates(int[] array)
{
    if (array.Length == 0)
    {
        return 0;
    }

    int write = 1;
    for (int read = 1; read < array.Length; read++)
    {
        if (array[read] != array[read - 1])
        {
            array[write++] = array[read];
        }
    }

    return write;
}
