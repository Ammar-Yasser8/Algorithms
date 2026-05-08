/*
Heap Sort Algorithm
-------------------
Heap sort builds a max heap and repeatedly extracts the maximum element.

Time Complexity: O(n log n)
Space Complexity: O(1)
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
        (array[0], array[i]) = (array[i], array[0]);
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
        (array[rootIndex], array[largest]) = (array[largest], array[rootIndex]);
        Heapify(array, length, largest);
    }
}
