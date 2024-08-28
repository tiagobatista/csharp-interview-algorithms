
/*
Linear Search is the simplest search algorithm.
It checks each element in the list sequentially until it finds the target element or reaches the end of the list.
Although it's not as efficient as Binary Search, Linear Search is straightforward and can be used on both sorted and unsorted arrays.
It’s most useful for small datasets or when the list is unsorted.
*/

public static class LinearSearchAlgorithm
{
    // Method to perform Linear Search on an array
    public static int LinearSearch(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            // Check if the current element is the target
            if (arr[i] == x)
                return i;
        }
        
        // Element not found in the array
        return -1;
    }
}
