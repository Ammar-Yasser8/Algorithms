/*
Number Pattern: Repeated Number Triangle
----------------------------------------
Example for rows = 5:
1
22
333
4444
55555
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
