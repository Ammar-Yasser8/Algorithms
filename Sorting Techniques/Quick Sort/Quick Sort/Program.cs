/*
Quick Sort Algorithm
--------------------
Quick sort selects a pivot and partitions the array so that elements smaller
than the pivot are on the left and larger elements are on the right.
It then recursively sorts the partitions.

Average Time Complexity: O(n log n)
Worst Time Complexity: O(n^2) when the pivot choices are poor
Space Complexity: O(log n) due to recursion stack
*/

int[] numbers = { 10, 7, 8, 9, 1, 5 };

QuickSort(numbers, 0, numbers.Length - 1);

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

void QuickSort(int[] array, int low, int high)
{
    if (low < high)
    {
        int pivotIndex = Partition(array, low, high);
        QuickSort(array, low, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, high);
    }
}

int Partition(int[] array, int low, int high)
{
    int pivot = array[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (array[j] <= pivot)
        {
            i++;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    int swap = array[i + 1];
    array[i + 1] = array[high];
    array[high] = swap;

    return i + 1;
}
