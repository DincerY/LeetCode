Solution solution = new();
solution.MinimumTotal2(new List<IList<int>>()
{
    new List<int>(){2},
    new List<int>(){3,4},
    new List<int>(){6,5,7},
    new List<int>(){4,1,8,3},
});


Console.WriteLine("Hello, World!");


public partial class Solution {
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

//it is not mine solution
public partial class Solution {
    public int MinimumTotal2 (IList<IList<int>> triangle) {
        if (triangle.Count == 1)
        {
            return triangle[0][0];
        }
        int[] dp = new int[triangle.Count + 1];
        for (int row = triangle.Count - 1; row >= 0; row--) {
            for (int i = 0; i < triangle[row].Count; i++) {
                dp[i] = triangle[row][i] + Math.Min(dp[i], dp[i + 1]);
            }
        }
        return dp[0];
    }
}

