/*
Algorithm: Linear Search
Time Complexity:
  Best: O(1)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(1)
Example:
  Input: numbers = [3, 5, 2, 4, 9], target = 2
  Output: index = 2
LeetCode:
  - https://leetcode.com/problems/two-sum/
  - https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
  - https://leetcode.com/problems/contains-duplicate/
*/

int[] numbers = { 3, 5, 2, 4, 9 };
int target = 2;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == target)
    {
        Console.WriteLine($"Target {target} found at index {i}");
        break;
    }

    if (i == numbers.Length - 1)
    {
        Console.WriteLine($"Target {target} not found in the array");
    }
}
