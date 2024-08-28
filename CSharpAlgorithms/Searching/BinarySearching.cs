
/*
Binary Search is an efficient algorithm for finding the position of a target element within a sorted array.
It works by repeatedly dividing the search interval in half.
If the target element is less than the middle element, the search continues in the lower half.
If it is greater, the search continues in the upper half.
This process continues until the target is found or the interval is empty.
Binary Search significantly reduces the time complexity compared to Linear Search, making it much faster for large datasets.
*/

class BinarySearchExample
{
    // Method to perform Binary Search on a sorted array
    static int BinarySearch(int[] arr, int left, int right, int x)
    {
        if (right >= left)
        {
            int mid = left + (right - left) / 2;

            // Check if the element is present at the middle itself
            if (arr[mid] == x)
                return mid;

            // If the element is smaller than mid, search the left subarray
            if (arr[mid] > x)
                return BinarySearch(arr, left, mid - 1, x);

            // Else search the right subarray
            return BinarySearch(arr, mid + 1, right, x);
        }

        // Element is not present in the array
        return -1;
    }  
}