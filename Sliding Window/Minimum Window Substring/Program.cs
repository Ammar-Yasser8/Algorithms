/*
Algorithm: Minimum Window Substring
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(alphabet)
Example:
  Input: s = "ADOBECODEBANC", t = "ABC"
  Output: "BANC"
LeetCode:
  - https://leetcode.com/problems/minimum-window-substring/
  - https://leetcode.com/problems/find-all-anagrams-in-a-string/
  - https://leetcode.com/problems/permutation-in-string/
*/

string s = "ADOBECODEBANC";
string t = "ABC";

string window = MinWindow(s, t);
Console.WriteLine($"Min window = {window}");

string MinWindow(string source, string target)
{
    if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
    {
        return string.Empty;
    }

    int[] required = new int[128];
    foreach (char c in target)
    {
        required[c]++;
    }

    int left = 0;
    int remaining = target.Length;
    int bestStart = 0;
    int bestLength = int.MaxValue;

    for (int right = 0; right < source.Length; right++)
    {
        char c = source[right];
        if (required[c] > 0)
        {
            remaining--;
        }

        required[c]--;

        while (remaining == 0)
        {
            int windowLength = right - left + 1;
            if (windowLength < bestLength)
            {
                bestLength = windowLength;
                bestStart = left;
            }

            char leftChar = source[left];
            required[leftChar]++;
            if (required[leftChar] > 0)
            {
                remaining++;
            }

            left++;
        }
    }

    return bestLength == int.MaxValue
        ? string.Empty
        : source.Substring(bestStart, bestLength);
}
