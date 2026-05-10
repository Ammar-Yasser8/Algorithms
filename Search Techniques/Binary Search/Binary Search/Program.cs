/*
Algorithm: Binary Search
Time Complexity:
  Best: O(1)
  Average: O(log n)
  Worst: O(log n)
Space Complexity: O(1)
Example:
  Input: numbers = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 20], target = 7
  Output: index = 3
LeetCode:
  - https://leetcode.com/problems/binary-search/
  - https://leetcode.com/problems/search-insert-position/
  - https://leetcode.com/problems/first-bad-version/
*/

int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 20 };
int target = 7;

int high = arr.Length - 1;
int low = 0;

while (low <= high)
{
    int mid = (high + low) / 2;
    if (arr[mid] == target)
    {
        Console.WriteLine($"Element found at index {mid}");
        break;
    }
    else if (arr[mid] < target)
    {
        low = mid + 1;
    }
    else
    {
        high = mid - 1;
    }
}
