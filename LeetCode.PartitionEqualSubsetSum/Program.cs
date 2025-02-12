Solution solution = new();
solution.CanPartition3(new[] { 1, 5, 11 ,5});
solution.CanPartition3(new[] {100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,99,97 });


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public bool CanPartition(int[] nums)
    {
        if (nums.Sum() % 2 != 0)
        {
            return false;
        }
        HashSet<int> dp = new HashSet<int>();
        dp.Add(0);
        int target = nums.Sum() / 2;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            HashSet<int> nextDP = new HashSet<int>();
            foreach (int t in dp)
            {
                if (t + nums[i] == target)
                {
                    return true;
                }

                nextDP.Add(t + nums[i]);
                nextDP.Add(t);
            }
            dp = nextDP;
        }
        return dp.Contains(target);
    }
}


public partial class Solution
{
    public bool CanPartition2(int[] nums)
    {
        bool res = false;
        var sum = nums.Sum();
        if (sum % 2 != 0)
        {
            return false;
        }

        void Backtrack(int index, int total)
        {
            if (total == (sum / 2))
            {
                res = true;
                return;
            }
            if (index >= nums.Length)
            {
                return;
            }
            total += nums[index];
            Backtrack(index+1,total);
            total -= nums[index];
            Backtrack(index+1,total);
        }
        Backtrack(0,0);
        return res;
    }
}
//Bellek dışı hatası veriyor.
public partial class Solution
{
    public bool CanPartition3(int[] nums)
    {
        bool res = false;
        var sum = nums.Sum();
        if (sum % 2 != 0)
        {
            return false;
        }
        sum /= 2;
        List<int> dp = new();
        dp.Add(0);
        for (int i = nums.Length-1; i >= 0; i--)
        {
            int count = dp.Count;
            for (int j = 0; j < count; j++)
            {
                if (dp[j] + nums[i] == sum)
                {
                    return true;
                }
                dp.Add(dp[j] + nums[i]);
            }
        }
        return false;
    }
}
//HashSet ile birden fazla aynı elemandan kurtulduk
public partial class Solution {
    public bool CanPartition4(int[] nums)
    {
        int sum = nums.Sum();
        if (sum % 2 != 0) {
            return false;
        }
        HashSet<int> dp = new HashSet<int>();
        dp.Add(0);
        sum /= 2;

        for (int i = nums.Length - 1; i >= 0; i--) {
            HashSet<int> nextDP = new HashSet<int>();
            foreach (int t in dp) {
                if (t + nums[i] == sum) {
                    return true;
                }
                nextDP.Add(t + nums[i]);
                nextDP.Add(t);
            }
            dp = nextDP;
        }
        return dp.Contains(sum);
    }
}