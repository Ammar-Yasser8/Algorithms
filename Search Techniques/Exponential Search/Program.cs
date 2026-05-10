/*
Algorithm: Exponential Search
Time Complexity:
  Best: O(1)
  Average: O(log n)
  Worst: O(log n)
Space Complexity: O(1)
Example:
  Input: numbers = [2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22], target = 14
  Output: index = 6
LeetCode:
  - https://leetcode.com/problems/binary-search/
  - https://leetcode.com/problems/search-insert-position/
  - https://leetcode.com/problems/first-bad-version/
*/

int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 };
int target = 14;

int index = ExponentialSearch(numbers, target);

Console.WriteLine(index >= 0
    ? $"Target {target} found at index {index}"
    : $"Target {target} not found in the array");

int ExponentialSearch(int[] array, int value)
{
    if (array.Length == 0)
    {
        return -1;
    }

    if (array[0] == value)
    {
        return 0;
    }

    int bound = 1;
    while (bound < array.Length && array[bound] <= value)
    {
        bound *= 2;
    }

    int left = bound / 2;
    int right = Math.Min(bound, array.Length - 1);

    return BinarySearch(array, value, left, right);
}

int BinarySearch(int[] array, int value, int left, int right)
{
    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (array[mid] == value)
        {
            return mid;
        }

        if (array[mid] < value)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1;
}
