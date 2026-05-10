/*
Algorithm: Max Subarray Sum (Fixed Window)
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(1)
Example:
  Input: numbers = [2, 1, 5, 1, 3, 2], k = 3
  Output: 9
LeetCode:
  - https://leetcode.com/problems/maximum-average-subarray-i/
  - https://leetcode.com/problems/minimum-size-subarray-sum/
  - https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/
*/

int[] numbers = { 2, 1, 5, 1, 3, 2 };
int k = 3;

int maxSum = MaxSubarraySum(numbers, k);
Console.WriteLine($"Max sum of {k} consecutive elements = {maxSum}");

int MaxSubarraySum(int[] array, int windowSize)
{
    if (array.Length == 0 || windowSize <= 0 || windowSize > array.Length)
    {
        return 0;
    }

    int windowSum = 0;
    for (int i = 0; i < windowSize; i++)
    {
        windowSum += array[i];
    }

    int best = windowSum;
    for (int i = windowSize; i < array.Length; i++)
    {
        windowSum += array[i] - array[i - windowSize];
        if (windowSum > best)
        {
            best = windowSum;
        }
    }

    return best;
}
