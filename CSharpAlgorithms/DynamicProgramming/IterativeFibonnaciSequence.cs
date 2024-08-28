
/*
The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, usually starting with 0 and 1.
That is, the sequence begins 0, 1, 1, 2, 3, 5, 8, 13, and so on.
The Fibonacci sequence can be calculated using a simple recursive approach, but this can be inefficient for large inputs due to the overlapping subproblems.
A more efficient way to compute Fibonacci numbers is by using dynamic programming.
This approach stores the results of subproblems in a table (or array) so that each subproblem is only solved once, reducing the time complexity from exponential O(2^n) to linear O(n)
Summary: The Fibonacci sequence is a series where each number is the sum of the two preceding ones.
It can be computed using various methods, including recursive, dynamic programming with memoization, and iterative approaches.
The choice of method affects the efficiency of the algorithm, with dynamic programming and iterative approaches being more efficient than the naive recursive approach.
*/

class FibonacciIterative
{
    // Method to calculate Fibonacci number iteratively
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n; // Base cases: F(0) = 0, F(1) = 1

        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b; // Calculate the next Fibonacci number
            a = b;
            b = c;
        }
        return c;
    }

    static void Main()
    {
        int n = 10;
        Console.WriteLine("Fibonacci(" + n + ") = " + Fibonacci(n));
    }
}
