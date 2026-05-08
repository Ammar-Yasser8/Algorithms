/*
Divide and Conquer: Maximum Element
-----------------------------------
We recursively split the array and compute the maximum of each half.

Time Complexity: O(n)
Space Complexity: O(log n) due to recursion stack
*/

int[] numbers = { 12, 5, 18, 7, 25, 3, 16 };

if (numbers.Length == 0)
{
    Console.WriteLine("Array is empty.");
}
else
{
    int maxValue = MaxDivideConquer(numbers, 0, numbers.Length - 1);
    Console.WriteLine($"Maximum value = {maxValue}");
}

int MaxDivideConquer(int[] array, int left, int right)
{
    if (left == right)
    {
        return array[left];
    }

    int mid = left + (right - left) / 2;
    int leftMax = MaxDivideConquer(array, left, mid);
    int rightMax = MaxDivideConquer(array, mid + 1, right);

    return Math.Max(leftMax, rightMax);
}
