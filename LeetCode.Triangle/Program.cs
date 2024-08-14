Solution solution = new();
solution.MinimumTotal(new List<IList<int>>()
{
    new List<int>(){2},
    new List<int>(){3,4},
    new List<int>(){6,5,7},
    new List<int>(){4,1,8,3},
});


Console.WriteLine("Hello, World!");


public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        if (triangle.Count == 1)
        {
            return triangle[0][0];
        }
        int res = Int32.MaxValue;
        void Dfs(int level, int index,int sum)
        {
            if (level >= triangle.Count)
            {
                res = Math.Min(sum, res);
                return;
            }

            sum += triangle[level][index];
            Dfs(level + 1,index, sum);
            Dfs(level + 1, index + 1, sum);
        }
        Dfs(0,0, 0);
        return res;
    }
}