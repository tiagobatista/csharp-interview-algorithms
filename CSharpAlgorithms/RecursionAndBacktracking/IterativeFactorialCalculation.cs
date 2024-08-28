
/*
The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
Factorials are used in various mathematical computations, including permutations and combinations.
Factorial can be calculated either iteratively, by multiplying numbers from 1 to n, or recursively, by multiplying n by the factorial of n−1.
*/

public static class IterativeFactorialCalculation
{
    // Method to calculate factorial iteratively
    public static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i; // Multiply result by i
        }
        return result;
    }
}
