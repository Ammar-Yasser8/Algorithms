/*
Algorithm: Counting Sort
Time Complexity:
  Best: O(n + k)
  Average: O(n + k)
  Worst: O(n + k)
Space Complexity: O(k)
Example:
  Input: [4, 2, 2, 8, 3, 3, 1]
  Output: [1, 2, 2, 3, 3, 4, 8]
LeetCode:
  - https://leetcode.com/problems/sort-colors/
  - https://leetcode.com/problems/relative-sort-array/
  - https://leetcode.com/problems/height-checker/
*/

int[] numbers = { 4, 2, 2, 8, 3, 3, 1 };

CountingSort(numbers);

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

void CountingSort(int[] array)
{
    if (array.Length == 0)
    {
        return;
    }

    int minValue = array.Min();
    if (minValue < 0)
    {
        Console.WriteLine("Error: This implementation of counting sort only supports non-negative integers. Array contains negative values.");
        return;
    }

    int maxValue = array.Max();
    int[] counts = new int[maxValue + 1];

    foreach (int number in array)
    {
        counts[number]++;
    }

    int index = 0;
    for (int i = 0; i < counts.Length; i++)
    {
        while (counts[i] > 0)
        {
            array[index++] = i;
            counts[i]--;
        }
    }
}
