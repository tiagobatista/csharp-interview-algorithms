
/*
The 0/1 Knapsack Problem is a classic optimization problem where you have a knapsack with a maximum weight capacity and a set of items, each with a weight and value.
The goal is to determine the maximum value you can obtain by selecting a subset of the items such that their total weight does not exceed the knapsack's capacity.
This problem is called "0/1" because each item can either be included (1) or excluded (0).
The challenge is to find the optimal combination of items.
The problem can be solved using dynamic programming, where you build a table to store the maximum value that can be obtained for each weight limit up to the knapsack's capacity.
This approach ensures that each subproblem is solved only once, making it efficient.
Summary: The 0/1 Knapsack Problem is an optimization problem where you aim to maximize the total value of items placed in a knapsack without exceeding its weight capacity.
The dynamic programming approach builds a table to store the best possible value for each subproblem, leading to an efficient solution.
*/


public static class KnapsackProblemAlgorithm
{
    // Method to solve 0/1 Knapsack problem using dynamic programming
    public static int Knapsack(int capacity, int[] weights, int[] values, int n)
    {
        // Create a DP table to store the maximum value for each weight limit
        int[,] dp = new int[n + 1, capacity + 1];

        // Build the table in a bottom-up manner
        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                if (i == 0 || w == 0)
                    dp[i, w] = 0; // Base case: no items or weight capacity is 0
                else if (weights[i - 1] <= w)
                    dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                else
                    dp[i, w] = dp[i - 1, w];
            }
        }

        // The value at dp[n][capacity] is the maximum value that can be achieved
        return dp[n, capacity];
    }
}
