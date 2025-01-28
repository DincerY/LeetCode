Solution solution = new();
solution.MinimumTotal4(new List<IList<int>>()
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


//Time limit exceeded (backtracking solution)
public partial class Solution {
    public int MinimumTotal3(IList<IList<int>> triangle)
    {
        int res = 100000;
        void BackTrack(int index, int depth,int sum)
        {
            if (depth < triangle.Count())
            {
                BackTrack(index,depth+1,sum+triangle[depth][index]);
                if (index+1 < triangle[depth].Count)
                {
                    BackTrack(index+1,depth+1, sum+triangle[depth][index+1]);
                }
            }
            else
            {
                res = Math.Min(res, sum);
            }
        }
        BackTrack(0,0,0);
        return res;
    }
}

//Dynamic programming memoization method
public partial class Solution {
    public int MinimumTotal4(IList<IList<int>> triangle)
    {
        Dictionary<(int, int), int> dp = new();
        int BackTrack(int index, int depth)
        {
            if (depth < triangle.Count())
            {
                if (dp.ContainsKey((depth, index)))
                {
                    return dp[(depth, index)];  
                }
                int left = BackTrack(index,depth+1);
                int right = 0;
                if (index+1 <= triangle[depth].Count)
                {
                    right = BackTrack(index+1,depth+1);
                }
                dp[(depth, index)] = triangle[depth][index] + Math.Min(left,right);
                return dp[(depth, index)];
            }
            else
            {
                return 0;
            }
        }
        BackTrack(0,0);
        return dp[(0,0)];
    }
}

//Dynamic programming tabulation method
public partial class Solution {
    public int MinimumTotal5(IList<IList<int>> triangle)
    {
        int[] arr = triangle[^1].ToArray();
        for (int i = triangle.Count()-2; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                int val = triangle[i][j];
                arr[j] = Math.Min(val + arr[j], val + arr[j+1]);
            }
        }
        return arr[0];
    }
}

