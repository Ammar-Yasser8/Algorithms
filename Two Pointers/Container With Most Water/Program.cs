/*
Algorithm: Container With Most Water
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(1)
Example:
  Input: [1, 8, 6, 2, 5, 4, 8, 3, 7]
  Output: 49
LeetCode:
  - https://leetcode.com/problems/container-with-most-water/
  - https://leetcode.com/problems/trapping-rain-water/
  - https://leetcode.com/problems/3sum/
*/

int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

int maxArea = MaxArea(heights);
Console.WriteLine($"Max area = {maxArea}");

int MaxArea(int[] height)
{
    int left = 0;
    int right = height.Length - 1;
    int best = 0;

    while (left < right)
    {
        int width = right - left;
        int current = Math.Min(height[left], height[right]) * width;
        if (current > best)
        {
            best = current;
        }

        if (height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return best;
}
