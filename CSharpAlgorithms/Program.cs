using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select an algorithm to run:");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Quick Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Binary Search");
            Console.WriteLine("5. Linear Search");
            Console.WriteLine("6. Recursive Factorial Calculation");
            Console.WriteLine("7. Iterative Factorial Calculation");
            Console.WriteLine("8. N Queens Problem");
            Console.WriteLine("9. Breadth-First Search (BFS)");
            Console.WriteLine("10. Depth-First Search (DFS)");
            Console.WriteLine("11. Iterative Fibonacci Sequence");
            Console.WriteLine("12. Memoization Fibonacci Sequence");
            Console.WriteLine("13. Recursive Fibonacci Sequence");
            Console.WriteLine("14. 0/1 Knapsack Problem");
            Console.WriteLine("15. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BubbleSortMenu();
                    break;
                case "2":
                    QuickSortMenu();
                    break;
                case "3":
                    MergeSortMenu();
                    break;
                case "4":
                    BinarySearchMenu();
                    break;
                case "5":
                    LinearSearchMenu();
                    break;
                case "6":
                    RecursiveFactorialMenu();
                    break;
                case "7":
                    IterativeFactorialMenu();
                    break;
                case "8":
                    NQueensMenu();
                    break;
                case "9":
                    BFSMenu();
                    break;
                case "10":
                    DFSMenu();
                    break;
                case "11":
                    IterativeFibonacciMenu();
                    break;
                case "12":
                    MemoizationFibonacciMenu();
                    break;
                case "13":
                    RecursiveFibonacciMenu();
                    break;
                case "14":
                    KnapsackMenu();
                    break;
                case "15":
                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid choice, please select a valid option.");
                    break;
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }

    static void BubbleSortMenu()
    {
        // Sample array
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        // Calling BubbleSort to sort the array
        BubbleSortAlgorithm.BubbleSort(arr);

        // Printing the sorted array
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }


    static void QuickSortMenu()
    {
        // Sample array
        int[] arr = { 10, 7, 8, 9, 1, 5 };

        // Calling QuickSort to sort the array
        QuickSortAlgorithm.QuickSort(arr, 0, arr.Length - 1);

        // Printing the sorted array
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }


    static void MergeSortMenu()
    {
        // Sample array
        int[] arr = { 12, 11, 13, 5, 6, 7 };

        // Calling MergeSort to sort the array
        MergeSortAlgorithm.MergeSort(arr, 0, arr.Length - 1);

        // Printing the sorted array
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }

    static void BinarySearchMenu()
    {
        // Example sorted array
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        // Element to search for
        int searchElement = 7;

        // Call the BinarySearch method
        int resultIndex = BinarySearchAlgorithm.BinarySearch(sortedArray, 0, sortedArray.Length - 1, searchElement);

        // Output the result
        if (resultIndex != -1)
        {
            Console.WriteLine($"Element {searchElement} found at index {resultIndex}.");
        }
        else
        {
            Console.WriteLine($"Element {searchElement} not found in the array.");
        }
    }

    static void LinearSearchMenu()
    {
        // Sample array
        int[] arr = { 2, 3, 4, 10, 40 };

        // Target element to search for
        int target = 10;

        // Calling LinearSearch to find the index of the target element
        int result = LinearSearchAlgorithm.LinearSearch(arr, target);
        
        // Printing the result
        if (result != -1)
            Console.WriteLine("Element found at index " + result);
        else
            Console.WriteLine("Element not found");
    }

    static void RecursiveFactorialMenu()
    {
        Console.WriteLine("Factorial Calculation selected.");
        Console.Write("Enter a non-negative integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of " + n + " is " + RecursiveFactorialCalculation.Factorial(n));
    }

    static void IterativeFactorialMenu()
    {
        Console.WriteLine("Factorial Calculation selected.");
        Console.Write("Enter a non-negative integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of " + n + " is " + IterativeFactorialCalculation.Factorial(n));
    }

    static void NQueensMenu()
    {
        // Initialize the chessboard with 0s
        int[,] board = new int[8, 8];

        // Try solving the N Queens problem
        if (NQueensProblemAlgorithm.SolveNQueens(board, 0))
            NQueensProblemAlgorithm.PrintSolution(board); // Print the solution if found
        else
            Console.WriteLine("No solution exists");
    }

    static void BFSMenu()
    {
        // Example graph represented as an adjacency list
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>()
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 3, 4 } },
            { 2, new List<int> { 0, 5, 6 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1 } },
            { 5, new List<int> { 2 } },
            { 6, new List<int> { 2 } }
        };

        // Perform BFS starting from node 0
        BFSAlgorithm.BFS(graph, 0);
    }

    static void DFSMenu()
    {
        // Example graph represented as an adjacency list
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>()
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 3, 4 } },
            { 2, new List<int> { 0, 5, 6 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1 } },
            { 5, new List<int> { 2 } },
            { 6, new List<int> { 2 } }
        };

        // Set to keep track of visited nodes
        HashSet<int> visited = new HashSet<int>();

        // Perform DFS starting from node 0
        DFSAlgorithm.DFS(graph, 0, visited);
    }

    static void IterativeFibonacciMenu()
    {
        int n = 10;
        Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciIterativeAlgorithm.Fibonacci(n));
    }

    static void MemoizationFibonacciMenu()
    {
        int n = 10;
        int[] memo = new int[n + 1];
        for (int i = 0; i <= n; i++)
            memo[i] = -1; // Initialize memoization array with -1

        Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciMemoizationAlgorithm.Fibonacci(n, memo));
    }

    static void RecursiveFibonacciMenu()
    {
        // Calculate Fibonacci number at position 10
        int n = 10;
        Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciRecursiveAlgorithm.Fibonacci(n));
    }

    static void KnapsackMenu()
    {
        // Example items with weights and values
        int[] values = { 60, 100, 120 };
        int[] weights = { 10, 20, 30 };
        int capacity = 50;
        int n = values.Length;

        // Calculate the maximum value for the given knapsack capacity
        Console.WriteLine("Maximum value in Knapsack = " + KnapsackProblemAlgorithm.Knapsack(capacity, weights, values, n));
    }
}
