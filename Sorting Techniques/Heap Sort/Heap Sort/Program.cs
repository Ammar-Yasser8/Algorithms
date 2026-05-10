/*
Algorithm: Heap Sort
Time Complexity:
  Best: O(n log n)
  Average: O(n log n)
  Worst: O(n log n)
Space Complexity: O(1)
Example:
  Input: [12, 11, 13, 5, 6, 7]
  Output: [5, 6, 7, 11, 12, 13]
LeetCode:
  - https://leetcode.com/problems/kth-largest-element-in-an-array/
  - https://leetcode.com/problems/top-k-frequent-elements/
  - https://leetcode.com/problems/merge-k-sorted-lists/
*/

int[] numbers = { 12, 11, 13, 5, 6, 7 };

HeapSort(numbers);

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

void HeapSort(int[] array)
{
    int length = array.Length;

    for (int i = length / 2 - 1; i >= 0; i--)
    {
        Heapify(array, length, i);
    }

    for (int i = length - 1; i > 0; i--)
    {
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;
        Heapify(array, i, 0);
    }
}

void Heapify(int[] array, int length, int rootIndex)
{
    int largest = rootIndex;
    int left = 2 * rootIndex + 1;
    int right = 2 * rootIndex + 2;

    if (left < length && array[left] > array[largest])
    {
        largest = left;
    }

    if (right < length && array[right] > array[largest])
    {
        largest = right;
    }

    if (largest != rootIndex)
    {
        int temp = array[rootIndex];
        array[rootIndex] = array[largest];
        array[largest] = temp;
        Heapify(array, length, largest);
    }
}
