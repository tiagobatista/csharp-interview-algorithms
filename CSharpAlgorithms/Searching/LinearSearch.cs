
/*
Linear Search is the simplest search algorithm.
It checks each element in the list sequentially until it finds the target element or reaches the end of the list.
Although it's not as efficient as Binary Search, Linear Search is straightforward and can be used on both sorted and unsorted arrays.
It’s most useful for small datasets or when the list is unsorted.
*/

class LinearSearchExample
{
    // Method to perform Linear Search on an array
    static int LinearSearch(int[] arr, int x)
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

    static void Main()
    {
        // Sample array
        int[] arr = { 2, 3, 4, 10, 40 };

        // Target element to search for
        int target = 10;

        // Calling LinearSearch to find the index of the target element
        int result = LinearSearch(arr, target);
        
        // Printing the result
        if (result != -1)
            Console.WriteLine("Element found at index " + result);
        else
            Console.WriteLine("Element not found");
    }
}
