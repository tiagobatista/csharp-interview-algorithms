
/*
Bubble Sort is a simple comparison-based algorithm.
It works by repeatedly stepping through the list, comparing adjacent elements, and swapping them if they are in the wrong order.
This process continues until the list is sorted.
 Bubble Sort is easy to understand but is not the most efficient sorting method, especially for large datasets.
*/

public static class BubbleSortAlgorithm
{
    // Method to perform Bubble Sort on an array
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        
        // Outer loop to traverse the entire array
        for (int i = 0; i < n - 1; i++)
        {
            // Inner loop to compare adjacent elements
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
