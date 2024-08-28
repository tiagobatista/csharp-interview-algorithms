
/*
Merge Sort is another divide-and-conquer algorithm.
It works by recursively dividing the array into halves until each sub-array contains only one element.
Then, it merges the sub-arrays back together in a sorted manner.
This method ensures that the entire array is sorted efficiently.
Merge Sort is stable and guarantees O(nlogn) performance, making it a reliable choice for sorting.
*/

public static class MergeSortAlgorithm
{
    // Method to perform Merge Sort on an array
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int mid = left + (right - left) / 2;

            // Recursively sort first and second halves
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            // Merge the sorted halves
            Merge(arr, left, mid, right);
        }
    }

    // Method to merge two halves of an array
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1; // Size of left subarray
        int n2 = right - mid; // Size of right subarray

        // Temporary arrays
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copy data to temporary arrays L[] and R[]
        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        // Merge the temporary arrays back into arr[left..right]
        int k = left;
        int i1 = 0, j1 = 0;
        while (i1 < n1 && j1 < n2)
        {
            if (L[i1] <= R[j1])
            {
                arr[k] = L[i1];
                i1++;
            }
            else
            {
                arr[k] = R[j1];
                j1++;
            }
            k++;
        }

        // Copy the remaining elements of L[], if any
        while (i1 < n1)
        {
            arr[k] = L[i1];
            i1++;
            k++;
        }

        // Copy the remaining elements of R[], if any
        while (j1 < n2)
        {
            arr[k] = R[j1];
            j1++;
            k++;
        }
    }
}
