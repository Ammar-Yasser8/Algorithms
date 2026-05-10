/*
Algorithm: Maximum Element (Divide and Conquer)
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(log n)
Example:
  Input: [12, 5, 18, 7, 25, 3, 16]
  Output: 25
LeetCode:
  - https://leetcode.com/problems/maximum-subarray/
  - https://leetcode.com/problems/majority-element/
  - https://leetcode.com/problems/kth-largest-element-in-an-array/
*/

int[] numbers = { 12, 5, 18, 7, 25, 3, 16 };

if (numbers.Length == 0)
{
    Console.WriteLine("Array is empty.");
}
else
{
    int maxValue = MaxDivideConquer(numbers, 0, numbers.Length - 1);
    Console.WriteLine($"Maximum value = {maxValue}");
}

int MaxDivideConquer(int[] array, int left, int right)
{
    if (left == right)
    {
        return array[left];
    }

    int mid = left + (right - left) / 2;
    int leftMax = MaxDivideConquer(array, left, mid);
    int rightMax = MaxDivideConquer(array, mid + 1, right);

    return Math.Max(leftMax, rightMax);
}
