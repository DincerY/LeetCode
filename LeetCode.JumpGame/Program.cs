Solution solution = new();
// var boolDeneme = solution.CanJump(new[] { 2, 3, 1, 1, 4 });
//var boolDeneme = solution.CanJump(new[] {7,2,1,1,1,1,0,0,8});

//var boolDeneme = solution.CanJump2(new[] { 2, 3, 1, 1, 4 });
var boolDeneme = solution.CanJump2(new[] { 6, 5, 1, 7, 0, 3, 5, 1, 9, 9, 3, 5, 0, 7, 5 });
var boolDenemee = solution.CanJump2(new[] { 10, 5, 4, 3, 2, 1, 0, 4 });
var boolDenemeee = solution.CanJump2(new[] { 2,3,1,1,4 });
var boolDenemeeee = solution.CanJump4(new[] { 3,2,1,1,4,0,0,0,4  });


Console.WriteLine(boolDeneme);


/// <summary>
/// Brute Force Solution
/// </summary>
public partial class Solution
{
    public bool CanJump(int[] nums)
    {
        int endIndex = nums.Length - 1;
        int canJump = nums[0];
        if (canJump >= 1 && endIndex == 0)
        {
            return true;
        }

        bool generalValue = false;

        bool Recursive(int index)
        {
            if (index == endIndex)
            {
                return generalValue = true;
            }

            canJump = nums[index];
            for (int i = 1; i <= canJump; i++)
            {
                if (index + i > endIndex)
                {
                    break;
                }

                Recursive(index + i);
                canJump = nums[index];
            }

            return generalValue;
        }

        return Recursive(0);
    }
}


/// <summary>
/// Dynamic Programming Solution
/// </summary>
public partial class Solution
{
    public bool CanJump2(int[] nums)
    {
        Dictionary<int, bool> dictionary = new();
        int endIndex = nums.Length - 1;
        int canJump = nums[0];
        if (canJump >= 1 && endIndex == 0)
        {
            return true;
        }

        bool generalValue = false;

        bool Recursive(int index)
        {
            if (index == endIndex)
            {
                return generalValue = true;
            }

            canJump = nums[index];

            for (int i = 1; i <= canJump; i++)
            {
                if (dictionary.ContainsKey(i + index) && !dictionary[i + index])
                {
                    continue;
                }

                if (index + i > endIndex)
                {
                    break;
                }

                Recursive(index + i);
                canJump = nums[index];
            }

            if (!dictionary.ContainsKey(index))
            {
                dictionary.Add(index, generalValue);
            }

            return generalValue;
        }

        return Recursive(0);
    }
}

/// <summary>
/// Greedy Solution
/// </summary>
public partial class Solution
{
    public bool CanJump3(int[] nums)
    {
        int length = nums.Length;
        int goal = length - 1;
        for (int i = length - 2; i >= 0; i--)
        {
            if (i + nums[i] >= goal)
            {
                goal = i;
            }
        }

        return goal == 0;
    }
}

public partial class Solution
{
    public bool CanJump4(int[] nums)
    {
        int max = 0;
        int i;
        for (i = 0; i < nums.Length && i <= max; i++)
        {
            max = Math.Max(max, i + nums[i]);
            if (max >= nums.Length - 1) return true;
        }

        return i == nums.Length;
    }
}

public partial class Solution
{
    public bool CanJump5(int[] nums)
    {
        bool[] dp = new bool[nums.Length];
        dp[nums.Length - 1] = true;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            for (int j = i; j <= Math.Min(nums[i] + i, nums.Length - 1); j++)
            {
                if (dp[j])
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[0];
    }
}