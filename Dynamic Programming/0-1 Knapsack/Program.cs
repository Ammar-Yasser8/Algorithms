/*
Algorithm: 0/1 Knapsack
Time Complexity:
  Best: O(n * W)
  Average: O(n * W)
  Worst: O(n * W)
Space Complexity: O(n * W)
Example:
  Input: weights = [2, 3, 4, 5], values = [3, 4, 5, 6], capacity = 5
  Output: 7
LeetCode:
  - https://leetcode.com/problems/partition-equal-subset-sum/
  - https://leetcode.com/problems/target-sum/
  - https://leetcode.com/problems/last-stone-weight-ii/
*/

int[] weights = { 2, 3, 4, 5 };
int[] values = { 3, 4, 5, 6 };
int capacity = 5;

int bestValue = Knapsack(weights, values, capacity);
Console.WriteLine($"Best value = {bestValue}");

int Knapsack(int[] w, int[] v, int cap)
{
    int n = w.Length;
    int[,] dp = new int[n + 1, cap + 1];

    for (int i = 1; i <= n; i++)
    {
        for (int current = 0; current <= cap; current++)
        {
            dp[i, current] = dp[i - 1, current];
            if (w[i - 1] <= current)
            {
                int candidate = dp[i - 1, current - w[i - 1]] + v[i - 1];
                if (candidate > dp[i, current])
                {
                    dp[i, current] = candidate;
                }
            }
        }
    }

    return dp[n, cap];
}
