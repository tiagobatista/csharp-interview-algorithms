
/*
Breadth-First Search (BFS) is a graph traversal algorithm that explores nodes level by level.
Starting from a source node, BFS visits all its neighbors before moving on to the next level of nodes.
This approach ensures that BFS finds the shortest path (in terms of the number of edges) from the source node to any other node in an unweighted graph.
BFS uses a queue data structure to keep track of nodes to visit next.
Nodes are marked as "visited" once they are enqueued to prevent revisiting them, which ensures that the algorithm efficiently traverses the graph.
Summary: BFS explores nodes level by level, starting from a given node and visiting all its neighbors before moving to the next level. It is particularly useful for finding the shortest path in unweighted graphs. BFS uses a queue to manage the nodes to be explored.
*/

public static class BFSAlgorithm
{
    // Method to perform BFS on a graph
    public static void BFS(Dictionary<int, List<int>> graph, int startNode)
    {
        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        // Enqueue the starting node and mark it as visited
        queue.Enqueue(startNode);
        visited.Add(startNode);

        while (queue.Count > 0)
        {
            int currentNode = queue.Dequeue();
            Console.Write(currentNode + " ");

            // Visit all the neighbors of the current node
            foreach (int neighbor in graph[currentNode])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }
}
