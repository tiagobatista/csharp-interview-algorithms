
/*
The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
Factorials are used in various mathematical computations, including permutations and combinations.
Factorial can be calculated either iteratively, by multiplying numbers from 1 to n, or recursively, by multiplying n by the factorial of n−1.
*/

class IterativeFactorialCalculatiom
{
    // Method to calculate factorial iteratively
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i; // Multiply result by i
        }
        return result;
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
