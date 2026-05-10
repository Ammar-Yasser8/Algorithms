/*
Algorithm: Bubble Sort
Time Complexity:
  Best: O(n)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(1)
Example:
  Input: [64, 34, 25, 12, 22, 11, 90]
  Output: [11, 12, 22, 25, 34, 64, 90]
LeetCode:
  - https://leetcode.com/problems/sort-an-array/
  - https://leetcode.com/problems/sort-colors/
  - https://leetcode.com/problems/kth-largest-element-in-an-array/
*/

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
for (int i = 0; i < arr.Length - 1; i++)
{
    bool swapped = false;
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
            swapped = true;
        }
    }

    if (!swapped)
    {
        break;
    }
}

Console.WriteLine("Sorted array: ");
foreach (var item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();
