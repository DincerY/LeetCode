using System.Net.Http.Headers;

Solution solution = new();
solution.NumTrees4(4);


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int NumTrees(int n)
    {
        Dictionary<int, int> dic = new();
        dic.Add(0, 0);
        dic.Add(1, 1);
        Recursion(n);

        void Recursion(int n)
        {
            int total = 0;
            if (!dic.ContainsKey(n))
            {
                Recursion(n - 1);
                if (dic.ContainsKey(n))
                {
                    int maxVal = n + 1;
                    for (int i = 1; i <= maxVal; i++)
                    {
                        int left = i - 1;
                        if (left == 0)
                        {
                            left = 1;
                        }
                        int right = maxVal - i;
                        if (right == 0)
                        {
                            right = 1;
                        }
                        dic.TryGetValue(left, out left);
                        dic.TryGetValue(right, out right);
                        total += left * right;
                    }
                    dic.TryAdd(n + 1, total);
                }
            }
            else
            {
                int maxVal = n + 1;
                for (int i = 1; i <= maxVal; i++)
                {
                    int left = i - 1;
                    if (left == 0)
                    {
                        left = 1;
                    }
                    int right = maxVal - i;
                    if (right == 0)
                    {
                        right = 1;
                    }
                    dic.TryGetValue(left, out left);
                    dic.TryGetValue(right, out right);
                    total += left * right;
                }

                dic.TryAdd(n + 1, total);
            }
        }

        int result = 0;
        dic.TryGetValue(n, out result);
        return result;
    }
}

public partial class Solution
{
    public int NumTrees2(int n)
    {
        int[] numTree = new int[n + 1];
        Array.Fill(numTree, 1);
        for (int nodes = 2; nodes <= n; nodes++)
        {
            int total = 0;
            for (int root = 1; root <= nodes; root++)
            {
                int left = root - 1;
                int right = nodes - root;
                total += numTree[left] * numTree[right];
            }
            numTree[nodes] = total;
        }
        return numTree[n];
    }
}


public partial class Solution
{
    public int NumTrees3(int n)
    {
        int[] dp = new int[n+1];
        dp[0] = 0;
        dp[1] = 1;
        int Recursion(int val)
        {
            if (dp[val] != 0)
            {
                return dp[val];
            }
            int res = 0;
            for (int i = 1; i < val+1; i++)
            {
                int left = i - 1;
                int right = val - i;
                if (dp[left] == 0)
                {
                    left = Recursion(left);
                }
                else
                {
                    left = dp[left];
                }

                if (dp[right] == 0)
                {
                    right = Recursion(right);
                }
                else
                {
                    right = dp[right];
                }

                left = left == 0 ? 1 : left;
                right = right == 0 ? 1 : right;
                res += left * right;
            }

            dp[val] = res;
            return res;
        }

        Recursion(n);
        return dp[^1];
    }
}

public partial class Solution
{
    public int NumTrees4(int n)
    {
        int[] arr = new int[n+1];
        arr[0] = 1;
        arr[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            int total = 0;
            for (int j = 1; j <= i; j++)
            {
                int left = j - 1;
                int right = i - j;
                total += arr[left] * arr[right];
            }
            arr[i] = total;
        }
        return arr[^1];
    }
}
