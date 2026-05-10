/*
Algorithm: Longest Common Subsequence
Time Complexity:
  Best: O(m * n)
  Average: O(m * n)
  Worst: O(m * n)
Space Complexity: O(m * n)
Example:
  Input: text1 = "abcde", text2 = "ace"
  Output: 3
LeetCode:
  - https://leetcode.com/problems/longest-common-subsequence/
  - https://leetcode.com/problems/delete-operation-for-two-strings/
  - https://leetcode.com/problems/shortest-common-supersequence/
*/

string text1 = "abcde";
string text2 = "ace";

int length = LcsLength(text1, text2);
Console.WriteLine($"LCS length = {length}");

int LcsLength(string first, string second)
{
    int m = first.Length;
    int n = second.Length;
    int[,] dp = new int[m + 1, n + 1];

    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (first[i - 1] == second[j - 1])
            {
                dp[i, j] = dp[i - 1, j - 1] + 1;
            }
            else
            {
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
    }

    return dp[m, n];
}
