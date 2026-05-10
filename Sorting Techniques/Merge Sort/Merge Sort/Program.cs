/*
Algorithm: Merge Sort
Time Complexity:
  Best: O(n log n)
  Average: O(n log n)
  Worst: O(n log n)
Space Complexity: O(n)
Example:
  Input: [38, 27, 43, 3, 9, 82, 10]
  Output: [3, 9, 10, 27, 38, 43, 82]
LeetCode:
  - https://leetcode.com/problems/sort-an-array/
  - https://leetcode.com/problems/count-of-smaller-numbers-after-self/
  - https://leetcode.com/problems/reverse-pairs/
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

    int leftIndex = 0;
    int rightIndex = 0;
    int mergeIndex = left;

    while (leftIndex < leftSize && rightIndex < rightSize)
    {
        if (leftArray[leftIndex] <= rightArray[rightIndex])
        {
            array[mergeIndex] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            array[mergeIndex] = rightArray[rightIndex];
            rightIndex++;
        }

        mergeIndex++;
    }

    while (leftIndex < leftSize)
    {
        array[mergeIndex] = leftArray[leftIndex];
        leftIndex++;
        mergeIndex++;
    }

    while (rightIndex < rightSize)
    {
        array[mergeIndex] = rightArray[rightIndex];
        rightIndex++;
        mergeIndex++;
    }
}
