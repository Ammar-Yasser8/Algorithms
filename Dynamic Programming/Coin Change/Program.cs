/*
Algorithm: Coin Change (Minimum Coins)
Time Complexity:
  Best: O(n * amount)
  Average: O(n * amount)
  Worst: O(n * amount)
Space Complexity: O(amount)
Example:
  Input: coins = [1, 2, 5], amount = 11
  Output: 3
LeetCode:
  - https://leetcode.com/problems/coin-change/
  - https://leetcode.com/problems/coin-change-ii/
  - https://leetcode.com/problems/perfect-squares/
*/

int[] coins = { 1, 2, 5 };
int amount = 11;

int minCoins = CoinChange(coins, amount);
Console.WriteLine($"Minimum coins = {minCoins}");

int CoinChange(int[] coinsList, int target)
{
    int[] dp = new int[target + 1];
    Array.Fill(dp, target + 1);
    dp[0] = 0;

    for (int i = 1; i <= target; i++)
    {
        foreach (int coin in coinsList)
        {
            if (coin <= i)
            {
                dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
            }
        }
    }

    return dp[target] > target ? -1 : dp[target];
}
