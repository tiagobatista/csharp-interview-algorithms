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
            Console.WriteLine("6. Factorial Calculation");
            Console.WriteLine("7. N Queens Problem");
            Console.WriteLine("8. Breadth-First Search (BFS)");
            Console.WriteLine("9. Depth-First Search (DFS)");
            Console.WriteLine("10. Fibonacci Sequence");
            Console.WriteLine("11. 0/1 Knapsack Problem");
            Console.WriteLine("12. Exit");
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
                    FactorialMenu();
                    break;
                case "7":
                    NQueensMenu();
                    break;
                case "8":
                    BFSMenu();
                    break;
                case "9":
                    DFSMenu();
                    break;
                case "10":
                    FibonacciMenu();
                    break;
                case "11":
                    KnapsackMenu();
                    break;
                case "12":
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
        Console.WriteLine("Bubble Sort selected.");
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array: " + string.Join(", ", array));
        BubbleSortAlgorithm(array);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }

    static void QuickSortMenu()
    {
        Console.WriteLine("Quick Sort selected.");
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array: " + string.Join(", ", array));
        QuickSortAlgorithm(array, 0, array.Length - 1);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }

    static void MergeSortMenu()
    {
        Console.WriteLine("Merge Sort selected.");
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array: " + string.Join(", ", array));
        MergeSortAlgorithm(array, 0, array.Length - 1);
        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }

    static void BinarySearchMenu()
    {
        Console.WriteLine("Binary Search selected.");
        int[] array = { 11, 22, 34, 64, 90 };
        Console.WriteLine("Array: " + string.Join(", ", array));
        Console.Write("Enter the value to search: ");
        int value = int.Parse(Console.ReadLine());
        int index = BinarySearchAlgorithm(array, value);
        if (index != -1)
            Console.WriteLine("Value found at index: " + index);
        else
            Console.WriteLine("Value not found.");
    }

    static void LinearSearchMenu()
    {
        Console.WriteLine("Linear Search selected.");
        int[] array = { 11, 22, 34, 64, 90 };
        Console.WriteLine("Array: " + string.Join(", ", array));
        Console.Write("Enter the value to search: ");
        int value = int.Parse(Console.ReadLine());
        int index = LinearSearchAlgorithm(array, value);
        if (index != -1)
            Console.WriteLine("Value found at index: " + index);
        else
            Console.WriteLine("Value not found.");
    }

    static void FactorialMenu()
    {
        Console.WriteLine("Factorial Calculation selected.");
        Console.Write("Enter a non-negative integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of " + n + " is " + FactorialAlgorithm(n));
    }

    static void NQueensMenu()
    {
        Console.WriteLine("N Queens Problem selected.");
        Console.Write("Enter the value of N (size of the chessboard): ");
        int n = int.Parse(Console.ReadLine());
        NQueensAlgorithm(n);
        // Output or display solution here
    }

    static void BFSMenu()
    {
        Console.WriteLine("Breadth-First Search (BFS) selected.");
        Console.Write("Enter the number of nodes: ");
        int nodes = int.Parse(Console.ReadLine());
        // Assume graph is represented by adjacency list or matrix
        Console.Write("Enter the start node: ");
        int startNode = int.Parse(Console.ReadLine());
        BFSAlgorithm(nodes, startNode);
        // Output or display BFS result here
    }

    static void DFSMenu()
    {
        Console.WriteLine("Depth-First Search (DFS) selected.");
        Console.Write("Enter the number of nodes: ");
        int nodes = int.Parse(Console.ReadLine());
        // Assume graph is represented by adjacency list or matrix
        Console.Write("Enter the start node: ");
        int startNode = int.Parse(Console.ReadLine());
        DFSAlgorithm(nodes, startNode);
        // Output or display DFS result here
    }

    static void FibonacciMenu()
    {
        Console.WriteLine("Fibonacci Sequence selected.");
        Console.Write("Enter the position in the Fibonacci sequence: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci number at position " + n + " is " + FibonacciAlgorithm(n));
    }

    static void KnapsackMenu()
    {
        Console.WriteLine("0/1 Knapsack Problem selected.");
        Console.Write("Enter the capacity of the knapsack: ");
        int capacity = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of items: ");
        int n = int.Parse(Console.ReadLine());
        int[] weights = new int[n];
        int[] values = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter weight for item " + (i + 1) + ": ");
            weights[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter value for item " + (i + 1) + ": ");
            values[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Maximum value in Knapsack = " + KnapsackAlgorithm(capacity, weights, values, n));
    }

    // Example algorithm method stubs (replace with actual implementations)

    static void BubbleSortAlgorithm(int[] array) 
    {
        // Implement Bubble Sort
    }

    static void QuickSortAlgorithm(int[] array, int low, int high)
    {
        // Implement Quick Sort
    }

    static void MergeSortAlgorithm(int[] array, int left, int right)
    {
        // Implement Merge Sort
    }

    static int BinarySearchAlgorithm(int[] array, int value)
    {
        // Implement Binary Search
        return -1; // Placeholder
    }

    static int LinearSearchAlgorithm(int[] array, int value)
    {
        // Implement Linear Search
        return -1; // Placeholder
    }

    static int FactorialAlgorithm(int n)
    {
        // Implement Factorial Calculation
        return 1; // Placeholder
    }

    static void NQueensAlgorithm(int n)
    {
        // Implement N Queens Problem
    }

    static void BFSAlgorithm(int nodes, int startNode)
    {
        // Implement Breadth-First Search
    }

    static void DFSAlgorithm(int nodes, int startNode)
    {
        // Implement Depth-First Search
    }

    static int FibonacciAlgorithm(int n)
    {
        // Implement Fibonacci Sequence
        return 0; // Placeholder
    }

    static int KnapsackAlgorithm(int capacity, int[] weights, int[] values, int n)
    {
        // Implement 0/1 Knapsack Problem
        return 0; // Placeholder
    }
}
