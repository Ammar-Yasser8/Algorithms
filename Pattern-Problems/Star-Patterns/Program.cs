/*
Algorithm: Centered Star Pyramid
Time Complexity:
  Best: O(n^2)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(1)
Example:
  Input: rows = 5
  Output:
      *
     ***
    *****
   *******
  *********
LeetCode:
  - https://leetcode.com/problems/spiral-matrix/
  - https://leetcode.com/problems/spiral-matrix-ii/
  - https://leetcode.com/problems/rotate-image/
*/

int rows = 5;

for (int i = 1; i <= rows; i++)
{
    Console.Write(new string(' ', rows - i));
    Console.WriteLine(new string('*', i * 2 - 1));
}
