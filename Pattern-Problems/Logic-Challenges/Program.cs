/*
Algorithm: Pascal's Triangle
Time Complexity:
  Best: O(n^2)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(1)
Example:
  Input: rows = 5
  Output:
    1
    1 1
    1 2 1
    1 3 3 1
    1 4 6 4 1
LeetCode:
  - https://leetcode.com/problems/pascals-triangle/
  - https://leetcode.com/problems/pascals-triangle-ii/
  - https://leetcode.com/problems/triangle/
*/

int rows = 6;

for (int i = 0; i < rows; i++)
{
    Console.Write(new string(' ', (rows - i) * 2));

    long value = 1;
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{value} ");
        value = (value * (i - j)) / (j + 1);
    }

    Console.WriteLine();
}
