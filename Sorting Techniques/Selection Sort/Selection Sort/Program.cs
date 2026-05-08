/*
Selection Sort Algorithm
------------------------
Selection sort repeatedly picks the smallest value from the unsorted portion
and places it at the beginning of the array.

Steps:
1) Assume the first element is the minimum.
2) Scan the remaining elements to find the actual minimum.
3) Swap the minimum with the first unsorted position.
4) Move the boundary forward and repeat.

Time Complexity: O(n^2) in all cases
Space Complexity: O(1)
*/

int[] numbers = { 64, 25, 12, 22, 11 };

for (int i = 0; i < numbers.Length - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[minIndex])
        {
            minIndex = j;
        }
    }

    if (minIndex != i)
    {
        int temp = numbers[i];
        numbers[i] = numbers[minIndex];
        numbers[minIndex] = temp;
    }
}

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
