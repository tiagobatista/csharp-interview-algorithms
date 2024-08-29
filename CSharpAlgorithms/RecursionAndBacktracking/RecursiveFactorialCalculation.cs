
/*
The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
Factorials are used in various mathematical computations, including permutations and combinations.
Factorial can be calculated either iteratively, by multiplying numbers from 1 to n, or recursively, by multiplying n by the factorial of n−1.
*/

public static class RecursiveFactorialCalculation
{
    // Method to calculate factorial recursively
    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1; // Base case: factorial of 0 or 1 is 1
        else
            return n * Factorial(n - 1); // Recursive case
    }
}
