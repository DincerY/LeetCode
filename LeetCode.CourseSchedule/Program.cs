Solution solution = new();
/*solution.CanFinish(2, new[]
{
    new[] { 1, 0 }
});

solution.CanFinish(2, new[]
{
    new[] { 1, 0 },
    new[] { 0, 1 },
});*/

solution.CanFinish2(5, new[]
{
    new[] { 0, 1 },
    new[] { 0, 2 },
    new[] { 1, 3 },
    new[] { 1, 4 },
    new[] { 3, 4 },
});
solution.CanFinish2(3, new[]
{
    new[] { 0, 1 },
    new[] { 1, 2 },
    new[] { 2, 0 }
});

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        if (prerequisites.Length == 0)
        {
            return true;
        }
        Dictionary<int, List<int>> preMap = new();
        foreach (var prerequisite in prerequisites)
        {
            if (!preMap.ContainsKey(prerequisite[0]))
            {
                preMap.Add(prerequisite[0], new List<int>() { prerequisite[1] });
            }
            else
            {
                preMap[prerequisite[0]].Add(prerequisite[1]);
            }
        }

        HashSet<int> visitSet = new();
        bool res = true;
        void Dfs(int nodeVal)
        {
            if (visitSet.Contains(nodeVal))
            {
                res = false;
                return;
            }

            if (!preMap.ContainsKey(nodeVal))
            {
                return;
            }

            visitSet.Add(nodeVal);
            foreach (var i in preMap[nodeVal])
            {
                Dfs(i);
            }
        }
        Dfs(preMap.Keys.FirstOrDefault());
        return res;
    }
}

//NeedCode solution
public partial class Solution
{
    public bool CanFinish2(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> preMap = new Dictionary<int, List<int>>();
        for (int i = 0; i < numCourses; i++)
        {
            preMap[i] = new List<int>();
        }
        foreach (var pair in prerequisites)
        {
            int crs = pair[0];
            int pre = pair[1];
            preMap[crs].Add(pre);
        }
        HashSet<int> visiting = new HashSet<int>();
        bool Dfs(int crs)
        {
            if (visiting.Contains(crs))
            {
                return false;
            }
            if (preMap[crs].Count == 0)
            {
                return true;
            }
            visiting.Add(crs);
            foreach (var pre in preMap[crs])
            {
                if (!Dfs(pre))
                {
                    return false;
                }
            }
            visiting.Remove(crs);
            preMap[crs].Clear();
            return true;
        }
        for (int c = 0; c < numCourses; c++)
        {
            if (!Dfs(c))
            {
                return false;
            }
        }
        return true;
    }
}

//Graph structure
public class Graph
{
    private Dictionary<int, List<int>> adjList = new();

    public void CreateGraph(int[][] prerequisites)
    {
        foreach (var prerequisite in prerequisites)
        {
            AddEdge(prerequisite[0], prerequisite[1]);
        }
    }

    public void AddVertex(int vertex)
    {
        if (!adjList.ContainsKey(vertex))
        {
            adjList[vertex] = new List<int>();
        }
    }

    public void AddEdge(int from, int to)
    {
        AddVertex(from);
        AddVertex(to);
        adjList[from].Add(to);
    }

    public void PrintGraph()
    {
        foreach (var kvp in adjList)
        {
            Console.WriteLine($"{kvp.Key} ->");
            foreach (var neig in kvp.Value)
            {
                Console.WriteLine($"{neig} ");
            }

            Console.WriteLine("");
        }
        Console.WriteLine("Printing Finished");
        
    }
    public void Dfs(int vertex, int count)
    {
        if (count > 100)
        {
            return;
        }
        if (!adjList.ContainsKey(vertex))
        {
            return;
        }

        if (adjList[vertex].Count <= 0)
        {
            Console.WriteLine($"vertex : {vertex}");
            return;
        }

        Console.WriteLine($"vertex : {vertex}");
        foreach (var vrtx in adjList[vertex])
        {
            Dfs(vrtx, count + 1);
        }
    }
}