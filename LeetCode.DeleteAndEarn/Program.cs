Solution solution = new();
//solution.DeleteAndEarn(new[] { 3, 4, 2 });
//solution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
//solution.DeleteAndEarn(new[] { 3,7,10,5,2,4,8,9,9,4,9,2,6,4,6,5,4,7,6,10 });


solution.CreateTree(new[] { 2, 3, 5, 7 });


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int DeleteAndEarn(int[] nums)
    {
        int res = 0;
        Array.Sort(nums);
        Dictionary<int, int> dp = new();
        List<int> list = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!list.Contains(nums[i]))
            {
                list.Add(nums[i]);
            }
            if (dp.ContainsKey(nums[i]))
            {
                dp[nums[i]]++;
            }
            else
            {
                dp.Add(nums[i], 1);
            }
        }
    
        return res;
    }
}


public partial class Solution
{
    public int CreateTree(int[] nums)
    {
        void Recursion(List<int> list,int i)
        {
            if (i == nums.Length)
            {
                return;
            }
            var temp = list.ToList();
            temp.Add(nums[i]);
            Recursion(temp,i+1);
            temp.ForEach(Console.Write);
            Console.WriteLine();
            Recursion(temp,i+1);
        }
        Recursion(new List<int>(),0);
        return 0;
    }
}