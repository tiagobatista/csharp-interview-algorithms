/*
Depth-First Search (DFS) is a graph traversal algorithm that explores as far as possible along each branch before backtracking.
Unlike BFS, which explores level by level, DFS dives deep into the graph, visiting nodes as far away from the starting node as possible before exploring other branches.
This approach can be implemented using either a stack (iterative method) or recursion.
DFS is particularly useful for scenarios where you need to explore all possible paths (e.g., solving mazes, finding connected components).
However, it doesn't guarantee the shortest path in unweighted graphs like BFS does.
Summary: DFS explores nodes by going as deep as possible before backtracking. 
It is useful for scenarios requiring exhaustive exploration, such as finding connected components or solving puzzles.
DFS can be implemented using recursion or a stack.
*/

public static class DFSAlgorithm
{
    // Method to perform DFS on a graph using recursion
    public static void DFS(Dictionary<int, List<int>> graph, int node, HashSet<int> visited)
    {
        visited.Add(node);
        Console.Write(node + " ");

        // Visit all the neighbors of the current node
        foreach (int neighbor in graph[node])
        {
            if (!visited.Contains(neighbor))
            {
                DFS(graph, neighbor, visited);
            }
        }
    }
}
