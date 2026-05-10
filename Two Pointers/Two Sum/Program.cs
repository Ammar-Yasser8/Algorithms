/*
Algorithm: Two Sum (Two Pointers on Sorted Array)
Time Complexity:
  Best: O(1)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(1)
Example:
  Input: numbers = [2, 7, 11, 15], target = 9
  Output: indices = [0, 1]
LeetCode:
  - https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
  - https://leetcode.com/problems/3sum/
  - https://leetcode.com/problems/3sum-closest/
*/

int[] numbers = { 2, 7, 11, 15 };
int target = 9;

int left = 0;
int right = numbers.Length - 1;
int[] result = { -1, -1 };

while (left < right)
{
    int sum = numbers[left] + numbers[right];
    if (sum == target)
    {
        result[0] = left;
        result[1] = right;
        break;
    }

    if (sum < target)
    {
        left++;
    }
    else
    {
        right--;
    }
}

Console.WriteLine(result[0] >= 0
    ? $"Indices: {result[0]}, {result[1]}"
    : "No pair found");
