/*
Algorithm: Quick Sort
Time Complexity:
  Best: O(n log n)
  Average: O(n log n)
  Worst: O(n^2)
Space Complexity: O(log n)
Example:
  Input: [10, 7, 8, 9, 1, 5]
  Output: [1, 5, 7, 8, 9, 10]
LeetCode:
  - https://leetcode.com/problems/sort-an-array/
  - https://leetcode.com/problems/kth-largest-element-in-an-array/
  - https://leetcode.com/problems/top-k-frequent-elements/
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
