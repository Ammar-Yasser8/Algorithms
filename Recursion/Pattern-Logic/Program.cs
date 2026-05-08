/*
Recursive Sum of Digits
-----------------------
This example uses recursion to add the digits of a number.

Time Complexity: O(d) where d is the number of digits
Space Complexity: O(d) due to recursion stack
*/

int number = 7531;
int sum = SumDigits(number);

Console.WriteLine($"Sum of digits in {number} = {sum}");

int SumDigits(int n)
{
    n = Math.Abs(n);

    if (n < 10)
    {
        return n;
    }

    return (n % 10) + SumDigits(n / 10);
}
