/*
The N Queens Problem is a classic example of a backtracking algorithm.
The objective is to place N queens on an N×N chessboard such that no two queens threaten each other.
This means that no two queens should share the same row, column, or diagonal.
The challenge is to find all possible arrangements of the N queens under these constraints.
The backtracking approach systematically explores each possibility, backtracking whenever a conflict is detected, until all solutions are found or all possibilities are exhausted.
*/

using System;

public static class NQueensProblemAlgorithm
{
    static int N = 8; // Size of the chessboard (8x8)

    // Method to print the solution board
    public static void PrintSolution(int[,] board)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(board[i, j] + " ");
            Console.WriteLine();
        }
    }

    // Method to check if a queen can be placed on board[row][col]
    static bool IsSafe(int[,] board, int row, int col)
    {
        int i, j;

        // Check this row on the left side
        for (i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;

        // Check upper diagonal on the left side
        for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;

        // Check lower diagonal on the left side
        for (i = row, j = col; j >= 0 && i < N; i++, j--)
            if (board[i, j] == 1)
                return false;

        return true;
    }

    // Recursive method to solve N Queens problem
    public static bool SolveNQueens(int[,] board, int col)
    {
        // Base case: If all queens are placed, return true
        if (col >= N)
            return true;

        // Consider this column and try placing this queen in all rows one by one
        for (int i = 0; i < N; i++)
        {
            // Check if placing the queen at board[i][col] is safe
            if (IsSafe(board, i, col))
            {
                board[i, col] = 1; // Place the queen

                // Recur to place the rest of the queens
                if (SolveNQueens(board, col + 1))
                    return true;

                // If placing queen in board[i][col] doesn't lead to a solution, remove the queen
                board[i, col] = 0; // Backtrack
            }
        }

        // If the queen cannot be placed in any row in this column, return false
        return false;
    }
}
