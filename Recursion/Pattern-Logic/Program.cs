/*
Pattern Logic: Recursive Number Triangle
---------------------------------------
Recursion is used to build each row and each column of the pattern.

Time Complexity: O(n^2)
Space Complexity: O(n) due to recursion stack
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
