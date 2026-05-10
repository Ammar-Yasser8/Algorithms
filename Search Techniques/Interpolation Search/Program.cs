/*
Algorithm: Interpolation Search
Time Complexity:
  Best: O(1)
  Average: O(log log n)
  Worst: O(n)
Space Complexity: O(1)
Example:
  Input: numbers = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100], target = 70
  Output: index = 6
LeetCode:
  - https://leetcode.com/problems/guess-number-higher-or-lower/
  - https://leetcode.com/problems/binary-search/
  - https://leetcode.com/problems/search-insert-position/
*/

int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int target = 70;

int index = InterpolationSearch(numbers, target);

Console.WriteLine(index >= 0
    ? $"Target {target} found at index {index}"
    : $"Target {target} not found in the array");

int InterpolationSearch(int[] array, int value)
{
    int low = 0;
    int high = array.Length - 1;

    while (low <= high && value >= array[low] && value <= array[high])
    {
        if (array[high] == array[low])
        {
            return array[low] == value ? low : -1;
        }

        long numerator = (long)(high - low) * (value - array[low]);
        long denominator = array[high] - array[low];
        int position = low + (int)(numerator / denominator);

        if (array[position] == value)
        {
            return position;
        }

        if (array[position] < value)
        {
            low = position + 1;
        }
        else
        {
            high = position - 1;
        }
    }

    return -1;
}
