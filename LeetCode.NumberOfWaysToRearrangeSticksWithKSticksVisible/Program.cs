Solution solution = new();
solution.RearrangeSticks(3, 2);
solution.RearrangeSticks(5, 5);
solution.RearrangeSticks(20, 11);


Console.WriteLine("Hello, World!");

//Needcode solution
//This problem so hard
//I can not understand
public partial class Solution
{
    public int RearrangeSticks(int n, int k)
    {
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Dfs(int N, int K)
        {
            if (N == K)
            {
                return 1;
            }

            if (N == 0 || K == 0)
            {
                return 0;
            }

            if (dp.ContainsKey((N, K)))
            {
                return dp[(N, K)];
            }

            dp[(N, K)] = Dfs(N - 1, K - 1) + ((N - 1) * Dfs(N - 1, K));
            return dp[(N, K)];
        }

        return Dfs(n, k) % (10^9+7);
    }
}