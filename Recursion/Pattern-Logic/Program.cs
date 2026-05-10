/*
Algorithm: Recursive Number Triangle
Time Complexity:
  Best: O(n^2)
  Average: O(n^2)
  Worst: O(n^2)
Space Complexity: O(n)
Example:
  Input: rows = 4
  Output:
    1
    12
    123
    1234
LeetCode:
  - https://leetcode.com/problems/pascals-triangle/
  - https://leetcode.com/problems/pascals-triangle-ii/
  - https://leetcode.com/problems/triangle/
*/

int rows = 5;

PrintRows(rows, 1);

void PrintRows(int totalRows, int currentRow)
{
    if (currentRow > totalRows)
    {
        return;
    }

    PrintRow(currentRow, 1);
    Console.WriteLine();
    PrintRows(totalRows, currentRow + 1);
}

void PrintRow(int row, int column)
{
    if (column > row)
    {
        return;
    }

    Console.Write(column);
    PrintRow(row, column + 1);
}
