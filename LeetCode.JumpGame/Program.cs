Solution solution = new();
// var boolDeneme = solution.CanJump(new[] { 2, 3, 1, 1, 4 });
//var boolDeneme = solution.CanJump(new[] {7,2,1,1,1,1,0,0,8});

//var boolDeneme = solution.CanJump2(new[] { 2, 3, 1, 1, 4 });
var boolDeneme = solution.CanJump2(new[] {6,5,1,7,0,3,5,1,9,9,3,5,0,7,5});

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
                if (dictionary.ContainsKey(i+index) && !dictionary[i+index])
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
        return true;
    }
    
}