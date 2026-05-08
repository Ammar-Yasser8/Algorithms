/*
Interpolation Search Algorithm
------------------------------
Interpolation search estimates the position of the target based on
value distribution in a sorted array.

Time Complexity: O(log log n) average, O(n) worst-case
Space Complexity: O(1)
*/

int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int target = 70;

int index = InterpolationSearch(numbers, target);

Console.WriteLine(index >= 0
    ? $"Target {target} found at index {index}"
    : $"Target {target} not found in the array");

int InterpolationSearch(int[] array, int value)
{
    int low = 0;
    int high = array.Length - 1;

    while (low <= high && value >= array[low] && value <= array[high])
    {
        if (array[high] == array[low])
        {
            return array[low] == value ? low : -1;
        }

        int position = low + (int)((double)(high - low) * (value - array[low])
            / (array[high] - array[low]));

        if (array[position] == value)
        {
            return position;
        }

        if (array[position] < value)
        {
            low = position + 1;
        }
        else
        {
            high = position - 1;
        }
    }

    return -1;
}
