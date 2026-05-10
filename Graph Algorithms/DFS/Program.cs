/*
Algorithm: Depth-First Search (DFS)
Time Complexity:
  Best: O(V + E)
  Average: O(V + E)
  Worst: O(V + E)
Space Complexity: O(V)
Example:
  Input: graph = [[1,2],[3],[3],[]], start = 0
  Output: traversal = [0, 1, 3, 2]
LeetCode:
  - https://leetcode.com/problems/number-of-islands/
  - https://leetcode.com/problems/clone-graph/
  - https://leetcode.com/problems/all-paths-from-source-to-target/
*/

List<int>[] graph =
{
    new() { 1, 2 },
    new() { 3 },
    new() { 3 },
    new()
};

bool[] visited = new bool[graph.Length];
List<int> order = new();

Dfs(graph, 0, visited, order);
Console.WriteLine("DFS order: " + string.Join(", ", order));

void Dfs(List<int>[] adjacency, int node, bool[] seen, List<int> result)
{
    seen[node] = true;
    result.Add(node);

    foreach (int neighbor in adjacency[node])
    {
        if (!seen[neighbor])
        {
            Dfs(adjacency, neighbor, seen, result);
        }
    }
}
