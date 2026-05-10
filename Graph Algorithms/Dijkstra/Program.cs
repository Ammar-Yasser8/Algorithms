/*
Algorithm: Dijkstra's Shortest Path
Time Complexity:
  Best: O((V + E) log V)
  Average: O((V + E) log V)
  Worst: O((V + E) log V)
Space Complexity: O(V + E)
Example:
  Input: edges = (0->1,4), (0->2,1), (2->1,2), (1->3,1), (2->3,5)
  Output: distances from 0 = [0, 3, 1, 4]
LeetCode:
  - https://leetcode.com/problems/network-delay-time/
  - https://leetcode.com/problems/path-with-minimum-effort/
  - https://leetcode.com/problems/swim-in-rising-water/
*/

List<(int to, int weight)>[] graph =
{
    new() { (1, 4), (2, 1) },
    new() { (3, 1) },
    new() { (1, 2), (3, 5) },
    new()
};

int[] distances = Dijkstra(graph, 0);
Console.WriteLine("Distances from 0: " + string.Join(", ", distances));

int[] Dijkstra(List<(int to, int weight)>[] adjacency, int start)
{
    int[] dist = Enumerable.Repeat(int.MaxValue, adjacency.Length).ToArray();
    dist[start] = 0;

    PriorityQueue<int, int> pq = new();
    pq.Enqueue(start, 0);

    while (pq.Count > 0)
    {
        pq.TryDequeue(out int node, out int currentDist);
        if (currentDist > dist[node])
        {
            continue;
        }

        foreach (var (to, weight) in adjacency[node])
        {
            int nextDist = currentDist + weight;
            if (nextDist < dist[to])
            {
                dist[to] = nextDist;
                pq.Enqueue(to, nextDist);
            }
        }
    }

    return dist;
}
