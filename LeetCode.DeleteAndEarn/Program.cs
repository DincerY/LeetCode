Solution solution = new();
//solution.DeleteAndEarn(new[] { 3, 4, 2 });
//solution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
solution.DeleteAndEarn(new[] { 3,7,10,5,2,4,8,9,9,4,9,2,6,4,6,5,4,7,6,10 });


Console.WriteLine("Hello, World!");


public class Solution
{
    public int DeleteAndEarn(int[] nums)
    {
        int res = 0;
        Dictionary<int, int> dp = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dp.ContainsKey(nums[i]))
            {
                dp[nums[i]]++;
            }
            else
            {
                dp.Add(nums[i], 1);
            }
        }

        foreach (var keyval in dp)
        {
            int sum = 0;
            List<int> ignore = new List<int>();
            ignore.Add(keyval.Key - 1);
            ignore.Add(keyval.Key + 1);
            foreach (var keyva in dp)
            {
                if (ignore.Contains(keyva.Key))
                {
                    continue;
                }
                sum += keyva.Key * keyva.Value;
                ignore.Add(keyva.Key - 1);
                ignore.Add(keyva.Key + 1);
            }

            res = Math.Max(res, sum);
        }

        return res;
    }
}