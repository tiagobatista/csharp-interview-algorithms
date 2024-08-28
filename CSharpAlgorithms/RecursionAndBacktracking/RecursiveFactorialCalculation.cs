
/*
The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
Factorials are used in various mathematical computations, including permutations and combinations.
Factorial can be calculated either iteratively, by multiplying numbers from 1 to n, or recursively, by multiplying n by the factorial of n−1.
*/

class RecursiveFactorialCalculation
{
    // Method to calculate factorial recursively
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1; // Base case: factorial of 0 or 1 is 1
        else
            return n * Factorial(n - 1); // Recursive case
    }

    static void Main()
    {
        // Number to calculate factorial for
        int num = 5;

        // Calling Factorial method
        int factorial = Factorial(num);

        // Printing the result
        Console.WriteLine("Factorial of " + num + " is: " + factorial);
    }
}
