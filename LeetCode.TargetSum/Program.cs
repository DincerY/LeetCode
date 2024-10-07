Solution solution = new();
solution.FindTargetSumWays2(new[] { 1, 1, 1, 1, 1 }, 3);


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        int res = 0;

        void Backtrack(int index, int total)
        {
            if (index >= nums.Length)
            {
                if (total == target)
                {
                    res++;
                }

                return;
            }

            Backtrack(index + 1, total + nums[index]);
            Backtrack(index + 1, total + -nums[index]);
        }

        Backtrack(0, 0);
        return res;
    }
}

//Needcode solution(Dynamic Programming)
public partial class Solution
{
    public int FindTargetSumWays2(int[] nums, int target)
    {
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Backtrack(int i, int total)
        {
            if (i == nums.Length)
            {
                return total == target ? 1 : 0;
            }

            if (dp.ContainsKey((i, total)))
            {
                return dp[(i, total)];
            }

            dp[(i, total)] = Backtrack(i + 1, total + nums[i]) + Backtrack(i + 1, total - nums[i]);
            return dp[(i, total)];
        }

        return Backtrack(0, 0);
    }
}