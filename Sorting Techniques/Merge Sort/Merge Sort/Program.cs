/*
Merge Sort Algorithm
--------------------
Merge sort uses the divide-and-conquer strategy:
1) Split the array into two halves.
2) Recursively sort each half.
3) Merge the two sorted halves.

Time Complexity: O(n log n)
Space Complexity: O(n) due to temporary arrays during merge.
*/

int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

MergeSort(numbers, 0, numbers.Length - 1);

Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

void MergeSort(int[] array, int left, int right)
{
    if (left >= right)
    {
        return;
    }

    int mid = left + (right - left) / 2;
    MergeSort(array, left, mid);
    MergeSort(array, mid + 1, right);
    Merge(array, left, mid, right);
}

void Merge(int[] array, int left, int mid, int right)
{
    int leftSize = mid - left + 1;
    int rightSize = right - mid;

    int[] leftArray = new int[leftSize];
    int[] rightArray = new int[rightSize];

    Array.Copy(array, left, leftArray, 0, leftSize);
    Array.Copy(array, mid + 1, rightArray, 0, rightSize);

    int i = 0;
    int j = 0;
    int k = left;

    while (i < leftSize && j < rightSize)
    {
        if (leftArray[i] <= rightArray[j])
        {
            array[k] = leftArray[i];
            i++;
        }
        else
        {
            array[k] = rightArray[j];
            j++;
        }

        k++;
    }

    while (i < leftSize)
    {
        array[k] = leftArray[i];
        i++;
        k++;
    }

    while (j < rightSize)
    {
        array[k] = rightArray[j];
        j++;
        k++;
    }
}
