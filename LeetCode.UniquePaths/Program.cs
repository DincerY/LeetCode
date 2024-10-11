Solution solution = new();
solution.UniquePaths2(3, 7);

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