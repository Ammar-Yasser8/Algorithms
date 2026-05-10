/*
Algorithm: Breadth-First Search (BFS)
Time Complexity:
  Best: O(V + E)
  Average: O(V + E)
  Worst: O(V + E)
Space Complexity: O(V)
Example:
  Input: graph = [[1,2],[2,3],[3],[]], start = 0
  Output: traversal = [0, 1, 2, 3]
LeetCode:
  - https://leetcode.com/problems/binary-tree-level-order-traversal/
  - https://leetcode.com/problems/number-of-islands/
  - https://leetcode.com/problems/01-matrix/
*/

List<int>[] graph =
{
    new() { 1, 2 },
    new() { 2, 3 },
    new() { 3 },
    new()
};

List<int> order = Bfs(graph, 0);
Console.WriteLine("BFS order: " + string.Join(", ", order));

List<int> Bfs(List<int>[] adjacency, int start)
{
    List<int> result = new();
    bool[] visited = new bool[adjacency.Length];
    Queue<int> queue = new();

    visited[start] = true;
    queue.Enqueue(start);

    while (queue.Count > 0)
    {
        int node = queue.Dequeue();
        result.Add(node);

        foreach (int neighbor in adjacency[node])
        {
            if (!visited[neighbor])
            {
                visited[neighbor] = true;
                queue.Enqueue(neighbor);
            }
        }
    }

    return result;
}
