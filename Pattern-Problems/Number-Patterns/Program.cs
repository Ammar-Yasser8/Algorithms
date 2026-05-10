/*
Algorithm: Repeated Number Triangle
Time Complexity:
  Best: O(n^2)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(1)
Example:
  Input: rows = 5
  Output:
    1
    22
    333
    4444
    55555
LeetCode:
  - https://leetcode.com/problems/pascals-triangle/
  - https://leetcode.com/problems/pascals-triangle-ii/
  - https://leetcode.com/problems/triangle/
*/

int rows = 5;

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);
    }

    Console.WriteLine();
}
