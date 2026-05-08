/*
Counting Sort Algorithm
-----------------------
Counting sort is efficient for integers within a known small range.

Time Complexity: O(n + k)
Space Complexity: O(k)
*/

int[] numbers = { 4, 2, 2, 8, 3, 3, 1 };

CountingSort(numbers);

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

void CountingSort(int[] array)
{
    if (array.Length == 0)
    {
        return;
    }

    int minValue = array.Min();
    if (minValue < 0)
    {
        Console.WriteLine("Error: Counting sort requires non-negative integers. Array contains negative values and cannot be sorted.");
        return;
    }

    int maxValue = array.Max();
    int[] counts = new int[maxValue + 1];

    foreach (int number in array)
    {
        counts[number]++;
    }

    int index = 0;
    for (int i = 0; i < counts.Length; i++)
    {
        while (counts[i] > 0)
        {
            array[index++] = i;
            counts[i]--;
        }
    }
}
