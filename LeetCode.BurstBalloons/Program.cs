Solution solution = new();
solution.MaxCoins2(new[] { 3, 1, 5, 8 });

Console.WriteLine("Hello, World!");

//NeedCode's solution
public partial class Solution
{
    public int MaxCoins(int[] nums)
    {
        List<int> newNums = new List<int> { 1 };
        newNums.AddRange(nums);
        newNums.Add(1);
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Dfs(int l, int r)
        {
            if (l > r)
            {
                return 0;
            }

            if (dp.ContainsKey((l, r)))
            {
                return dp[(l, r)];
            }

            dp[(l, r)] = 0;
            for (int i = l; i <= r; i++)
            {
                int coins = newNums[l - 1] * newNums[i] * newNums[r + 1];
                coins += Dfs(l, i - 1) + Dfs(i + 1, r);
                dp[(l, r)] = Math.Max(dp[(l, r)], coins);
            }

            return dp[(l, r)];
        }

        return Dfs(1, newNums.Count - 2);
    }
}


public partial class Solution
{
    public int MaxCoins2(int[] nums)
    {
        List<int> newNums = new List<int> { 1 };
        newNums.AddRange(nums);
        newNums.Add(1);
        void Recursion(List<int> tempNums,int first)
        {
            int total = 0;
            for (int i = first; i < newNums.Count-1; i++)
            {
                total += tempNums[i-1] * tempNums[i] * tempNums[i+1];
                var numList = tempNums.ToList();
                numList.RemoveAt(i);
                Recursion(numList,i + 1);
            }
        }

        Recursion(newNums,1);
        return 0;
    }
}