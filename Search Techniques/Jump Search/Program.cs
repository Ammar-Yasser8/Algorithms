/*
Jump Search Algorithm
---------------------
Jump search works on sorted arrays by jumping ahead fixed steps,
then performing a linear search within the identified block.

Time Complexity: O(√n)
Space Complexity: O(1)
*/

int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
int target = 15;

int index = JumpSearch(numbers, target);

Console.WriteLine(index >= 0
    ? $"Target {target} found at index {index}"
    : $"Target {target} not found in the array");

int JumpSearch(int[] array, int value)
{
    if (array.Length == 0)
    {
        return -1;
    }

    int length = array.Length;
    int step = Math.Max(1, (int)Math.Floor(Math.Sqrt(length)));
    int prev = 0;

    while (prev < length && array[Math.Min(step, length) - 1] < value)
    {
        prev = step;
        step += (int)Math.Floor(Math.Sqrt(length));

        if (prev >= length)
        {
            return -1;
        }
    }

    for (int i = prev; i < Math.Min(step, length); i++)
    {
        if (array[i] == value)
        {
            return i;
        }
    }

    return -1;
}
