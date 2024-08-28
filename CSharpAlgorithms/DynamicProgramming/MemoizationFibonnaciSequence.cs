
/*
The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, usually starting with 0 and 1.
That is, the sequence begins 0, 1, 1, 2, 3, 5, 8, 13, and so on.
The Fibonacci sequence can be calculated using a simple recursive approach, but this can be inefficient for large inputs due to the overlapping subproblems.
A more efficient way to compute Fibonacci numbers is by using dynamic programming.
This approach stores the results of subproblems in a table (or array) so that each subproblem is only solved once, reducing the time complexity from exponential O(2^n) to linear O(n)
Summary: The Fibonacci sequence is a series where each number is the sum of the two preceding ones.
It can be computed using various methods, including recursive, dynamic programming with memoization, and iterative approaches.
The choice of method affects the efficiency of the algorithm, with dynamic programming and iterative approaches being more efficient than the naive recursive approach.

Memoization is a technique used in computer science to optimize the performance of recursive algorithms by storing the results of expensive function calls and reusing these results when the same inputs occur again.
This helps to avoid redundant calculations and improve the efficiency of algorithms, especially those involving overlapping subproblems.

*/


public static class FibonacciMemoizationAlgorithm
{
    // Method to calculate Fibonacci number using memoization
    public static int Fibonacci(int n, int[] memo)
    {
        if (n <= 1)
            return n; // Base cases: F(0) = 0, F(1) = 1
        if (memo[n] != -1)
            return memo[n]; // Return memoized result if available

        memo[n] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo); // Store result in memo
        return memo[n];
    }
}
