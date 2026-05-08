/*
Factorial Using Recursion
------------------------
Recursion breaks the problem into smaller versions until it hits a base case.

Time Complexity: O(n)
Space Complexity: O(n) due to recursion stack
*/

int number = 5;

if (number < 0)
{
    Console.WriteLine("Factorial is not defined for negative numbers.");
}
else
{
    long result = Factorial(number);
    Console.WriteLine($"Factorial of {number} = {result}");
}

long Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }

    return n * Factorial(n - 1);
}
