/*
Algorithm: Union-Find (Disjoint Set Union)
Time Complexity:
  Best: O(α(n))
  Average: O(α(n))
  Worst: O(α(n))
Space Complexity: O(n)
Example:
  Input: n = 5, unions = (0,1), (1,2), (3,4)
  Output: connected(0,2) = true, connected(0,4) = false
LeetCode:
  - https://leetcode.com/problems/number-of-provinces/
  - https://leetcode.com/problems/redundant-connection/
  - https://leetcode.com/problems/accounts-merge/
*/

int n = 5;
UnionFind uf = new(n);
uf.Union(0, 1);
uf.Union(1, 2);
uf.Union(3, 4);

Console.WriteLine($"Connected 0-2: {uf.Connected(0, 2)}");
Console.WriteLine($"Connected 0-4: {uf.Connected(0, 4)}");

class UnionFind
{
    private readonly int[] parent;
    private readonly int[] rank;

    public UnionFind(int size)
    {
        parent = new int[size];
        rank = new int[size];
        for (int i = 0; i < size; i++)
        {
            parent[i] = i;
        }
    }

    public int Find(int x)
    {
        if (parent[x] != x)
        {
            parent[x] = Find(parent[x]);
        }

        return parent[x];
    }

    public void Union(int a, int b)
    {
        int rootA = Find(a);
        int rootB = Find(b);
        if (rootA == rootB)
        {
            return;
        }

        if (rank[rootA] < rank[rootB])
        {
            parent[rootA] = rootB;
        }
        else if (rank[rootA] > rank[rootB])
        {
            parent[rootB] = rootA;
        }
        else
        {
            parent[rootB] = rootA;
            rank[rootA]++;
        }
    }

    public bool Connected(int a, int b)
    {
        return Find(a) == Find(b);
    }
}
