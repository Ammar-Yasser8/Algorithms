/*
Logic Challenge: Pascal's Triangle
----------------------------------
Each number is the sum of the two numbers directly above it.
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
