Solution solution = new();
solution.CombinationSum4(new []{1,2,3},4);
solution.CombinationSum4(new []{9},3);


Console.WriteLine("Hello, World!");

//Time Limit Exceeded
public partial class Solution
{
    public int CombinationSum4(int[] nums, int target)
    {
        int res = 0;
        void Backtrack(int value)   
        {
            if (value > target)
            {
                return;
            }
            
            if (value == target)
            {
                res++;
            }

            foreach (var num in nums)
            {
                Backtrack(value+num);
            }
        }

        Backtrack(0);
        return res;
    }
}

public partial class Solution
{
    public int CombinationSum4Dp(int[] nums, int target)
    {
        int res = 0;
        
        return res;
    }
}