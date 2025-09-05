Solution solution = new();
solution.IncreasingTriplet(new []{1, 2, 3, 4, 5});

Console.WriteLine("Hello, World!");


public class Solution {
    public bool IncreasingTriplet(int[] nums)
    {
        int len = nums.Length;
        for (int i = 0; i < len; i++)
        {
            for (int j = i; j < len; j++)
            {
                for (int k = j; k < len; k++)
                {
                    
                }
            }
        }

        return false;
    }
    
    public bool IncreasingTriplet2(int[] nums)
    {
        //value , index
        Dictionary<int, int> dic = new();
        for (int i = 0; i < nums.Length; i++)
        {
            dic.Add(nums[i],i);
        }
        
        Array.Sort(nums);
        
        return false;
    }
}