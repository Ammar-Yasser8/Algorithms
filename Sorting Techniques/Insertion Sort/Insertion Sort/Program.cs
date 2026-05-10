/*
Algorithm: Insertion Sort
Time Complexity:
  Best: O(n)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(1)
Example:
  Input: [5, 2, 9, 1, 5, 6]
  Output: [1, 2, 5, 5, 6, 9]
LeetCode:
  - https://leetcode.com/problems/insertion-sort-list/
  - https://leetcode.com/problems/sort-an-array/
  - https://leetcode.com/problems/sort-colors/
*/

int[] array = { 5, 2, 9, 1, 5, 6 };
for (int i = 0; i < array.Length - 1; i++)
{
    int currentElement = array[i + 1];
    int j = i;
    while (j >= 0 && array[j] > currentElement)
    {
        array[j + 1] = array[j];
        j--;
    }

    array[j + 1] = currentElement;
}

Console.WriteLine("Sorted array: " + string.Join(", ", array));
