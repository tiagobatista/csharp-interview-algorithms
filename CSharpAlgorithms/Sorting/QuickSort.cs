
/*
Quick Sort is a highly efficient sorting algorithm that uses the divide-and-conquer approach.
The algorithm selects a "pivot" element from the array and partitions the other elements into two sub-arrays: those less than the pivot and those greater than the pivot.
The sub-arrays are then sorted recursively.
This process continues until the entire array is sorted.
Quick Sort is generally faster than Bubble Sort and is widely used due to its efficiency.
*/

class QuickSortExample
{
    // Method to perform Quick Sort on an array
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // pi is the partitioning index, arr[pi] is now at the right place
            int pi = Partition(arr, low, high);

            // Recursively sort elements before partition and after partition
            QuickSort(arr, low, pi - 1); // Before pi
            QuickSort(arr, pi + 1, high); // After pi
        }
    }

    // Method to take last element as pivot, places it at correct position, 
    // and places all smaller elements to the left and all larger elements to the right
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Pivot element
        int i = (low - 1); // Index of the smaller element

        // Traverse through all elements and compare with the pivot
        for (int j = low; j < high; j++)
        {
            // If the current element is smaller than or equal to pivot
            if (arr[j] <= pivot)
            {
                i++;
                // Swap arr[i] and arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Swap arr[i + 1] and arr[high] (or pivot)
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1; // Return the partitioning index
    }

    static void Main()
    {
        // Sample array
        int[] arr = { 10, 7, 8, 9, 1, 5 };

        // Calling QuickSort to sort the array
        QuickSort(arr, 0, arr.Length - 1);
        
        // Printing the sorted array
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
}
