Solution solution = new();
solution.CanFinish(2, new[]
{
    new[] { 1, 0 }
});

solution.CanFinish(2, new[]
{
    new[] { 1, 0 },
    new[] { 0, 1 },
});

solution.CanFinish(2, new[]
{
    new[] { 0, 1 },
    new[] { 0, 2 },
    new[] { 1, 3 },
    new[] { 1, 4 },
    new[] { 3, 4 },

});

Console.WriteLine("Hello, World!");


public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Graph g = new();
        g.CreateGraph(prerequisites);
        g.Dfs(0,0);
        
        g.PrintGraph();
        
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
            AddEdge(prerequisite[0],prerequisite[1]);
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
            Dfs(vrtx,count+1);
        }
    }
    
}