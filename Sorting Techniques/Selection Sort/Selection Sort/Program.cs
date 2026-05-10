/*
Algorithm: Selection Sort
Time Complexity:
  Best: O(n^2)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(1)
Example:
  Input: [64, 25, 12, 22, 11]
  Output: [11, 12, 22, 25, 64]
LeetCode:
  - https://leetcode.com/problems/sort-an-array/
  - https://leetcode.com/problems/relative-sort-array/
  - https://leetcode.com/problems/sort-array-by-increasing-frequency/
*/

int[] numbers = { 64, 25, 12, 22, 11 };

for (int i = 0; i < numbers.Length - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[minIndex])
        {
            minIndex = j;
        }
    }

    if (minIndex != i)
    {
        int temp = numbers[i];
        numbers[i] = numbers[minIndex];
        numbers[minIndex] = temp;
    }
}

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
