/*Binary Search is a classic algorithm used to find the position of a target value within a sorted array.
 The algorithm works by repeatedly dividing the search interval in half.
 If the value of the target is less than the value in the middle of the interval,
the search continues in the lower half. Otherwise, it continues in the upper half.
 This process is repeated until the target value is found or the interval is empty.*/

// Complexity Analysis:
// Time Complexity: O(log n) - Because the search space is halved with each iteration.
// Space Complexity: O(1) - No additional space is used that grows with input size.

/* Binary Search Algorithm 
    1- Initialize two variabes, low and high, to the start and end of the array.
    2- In a loop, calculate the mid index as the average of low and high.
    3- If the element at mid is equal to the target, return mid.
    4- If the element at mid is less than the target, set low to mid + 1.
    5- If the element at mid is greater than the target, set high to mid - 1.
    6- If low exceeds high, the target is not in the array; return -1.
 */

// Binary Search Example

int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19,20 };
int target = 7;

int high = arr.Length - 1;
int low = 0;

while (low <= high)
{
    int mid = (high + low) / 2;
    if (arr[mid] == target)
    {
        Console.WriteLine($"Element found at index {mid}");
        break;
    }
    else if (arr[mid] < target)
    {
        low = mid + 1;
    }
    else
    {
        high = mid - 1;
    }
}


