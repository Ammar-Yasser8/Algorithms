/*
Algorithm: Factorial (Recursion)
Time Complexity:
  Best: O(n)
  Average: O(n)
  Worst: O(n)
Space Complexity: O(n)
Example:
  Input: n = 5
  Output: 120
LeetCode:
  - https://leetcode.com/problems/fibonacci-number/
  - https://leetcode.com/problems/climbing-stairs/
  - https://leetcode.com/problems/powx-n/
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
