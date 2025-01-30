Solution solution = new();
solution.UniquePaths5(3, 7);

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[] arr = new int[n];
        arr[n - 1] = 1;
        for (int i = 0; i < m; i++)
        {
            int[] newArr = new int[n];
            newArr[n - 1] = 1;

            for (int j = n - 2; j >= 0; j--)
            {
                newArr[j] = newArr[j + 1] + arr[j];
            }
            arr = newArr;
        }
        return arr[0];
    }
}


public partial class Solution
{
    public int UniquePaths2(int m, int n)
    {
        int[] dp = new int[n];
        Array.Fill(dp,1);
        for (int i = 0; i < m-1; i++)
        {
            for (int j = n-2; j >= 0; j--)
            {
                dp[j] = dp[j] + dp[j + 1];
            }
        }

        return dp[0];
    }
}





public partial class Solution
{
    public int UniquePaths3(int m, int n)
    {
        int[,] dp = new int[m, n];
        dp[m - 1, n - 1] = 1;
        int Backtrack(int i, int j)
        {
            if (i >= m || j >= n)
            {
                return 0;
            }
            if (dp[i,j] != 0)
            {
                return dp[i, j];
            }
            int down = Backtrack(i+1,j);
            int right = Backtrack(i,j+1);
            dp[i, j] = right + down;
            return dp[i, j];
        }
        Backtrack(0,0);
        return dp[0,0];
    }
}

public partial class Solution {
    public int UniquePaths4(int m, int n) 
    {
        int[,] arr = new int[m, n];
        void Backtrack(int i, int j)
        {
            if (i >= m || j >= n)
            {
                return;
            }
            else
            {
                arr[i, j]++;
            }
            Backtrack(i+1,j);
            Backtrack(i,j+1);
        }
        Backtrack(0,0);
        return arr[m-1,n-1];
    }
}
public partial class Solution {
    public int UniquePaths5(int m, int n) 
    {
        int[] arr = new int[n];
        Array.Fill(arr,1);
        for (int i = 0; i < m-1; i++)
        {
            for (int j = n-2; j >= 0; j--)
            {
                arr[j] = arr[j] + arr[j + 1];
            }
        }
        return arr[0];
    }
}
