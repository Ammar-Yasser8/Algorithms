/*
Algorithm: Fibonacci (Memoization and Tabulation)
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(n)
Example:
  Input: n = 6
  Output: 8
LeetCode:
  - https://leetcode.com/problems/fibonacci-number/
  - https://leetcode.com/problems/climbing-stairs/
  - https://leetcode.com/problems/n-th-tribonacci-number/
*/

int n = 6;

long memoResult = FibonacciMemo(n, new Dictionary<int, long>());
long tabResult = FibonacciTab(n);

Console.WriteLine($"Memoized Fibonacci({n}) = {memoResult}");
Console.WriteLine($"Tabulated Fibonacci({n}) = {tabResult}");

long FibonacciMemo(int value, Dictionary<int, long> memo)
{
    if (value <= 1)
    {
        return value;
    }

    if (memo.TryGetValue(value, out long cached))
    {
        return cached;
    }

    long result = FibonacciMemo(value - 1, memo) + FibonacciMemo(value - 2, memo);
    memo[value] = result;
    return result;
}

long FibonacciTab(int value)
{
    if (value <= 1)
    {
        return value;
    }

    long[] dp = new long[value + 1];
    dp[0] = 0;
    dp[1] = 1;

    for (int i = 2; i <= value; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2];
    }

    return dp[value];
}
