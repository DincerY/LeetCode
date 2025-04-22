Solution solution = new();
solution.ContainsDuplicate(new []{1,2,3,1});

Console.WriteLine("Hello, World!");

public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                hash.Add(nums[i]);
            }
        }
        return false;
    }
}