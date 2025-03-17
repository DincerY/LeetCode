Solution solution = new();
solution.MaxCoins2(new[] { 3, 1, 5, 8 });
solution.MaxCoins2(new[] { 7,9,8,0,7,1,3,5,5 });

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
        int res = 0;
        void Backtrack(List<int> list,int total)
        {
            if (list.Count == 0)
            {
                res = Math.Max(res, total);
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                var tempList = list.ToList();
                var val = tempList[i];
                var left = i - 1 >= 0 ? tempList[i - 1] : 1;
                var right = i + 1 < tempList.Count ? tempList[i+1] : 1;
                int product = left * right;
                tempList.RemoveAt(i);
                Backtrack(tempList,total + val * product);
            }
        }
        Backtrack(nums.ToList(),0);
        return res;
    }
}
