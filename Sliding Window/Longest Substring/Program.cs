/*
Algorithm: Longest Substring Without Repeating Characters
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(min(n, alphabet))
Example:
  Input: "abcabcbb"
  Output: 3
LeetCode:
  - https://leetcode.com/problems/longest-substring-without-repeating-characters/
  - https://leetcode.com/problems/longest-repeating-character-replacement/
  - https://leetcode.com/problems/permutation-in-string/
*/

string text = "abcabcbb";

int longest = LongestUniqueSubstring(text);
Console.WriteLine($"Longest unique substring length = {longest}");

int LongestUniqueSubstring(string s)
{
    Dictionary<char, int> lastSeen = new();
    int left = 0;
    int best = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char current = s[right];
        if (lastSeen.TryGetValue(current, out int lastIndex) && lastIndex >= left)
        {
            left = lastIndex + 1;
        }

        lastSeen[current] = right;
        int windowLength = right - left + 1;
        if (windowLength > best)
        {
            best = windowLength;
        }
    }

    return best;
}
