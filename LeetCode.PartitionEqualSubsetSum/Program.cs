Solution solution = new();
solution.CanPartition(new[] { 1, 5, 11 ,5});


Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
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