Solution solution = new();
// solution.SubsetsWithDup(new[]
// {
//     1, 2, 2
// });

solution.SubsetsWithDup(new []
{
    1,2,2
});



Console.WriteLine("Hello, World!");



public partial class Solution {
    public IList<IList<int>> SubsetsWithDup2(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> subset = new List<int>();
        Dfs(0);
        return res;
        void Dfs(int i)
        {
            if (i == nums.Length)
            {
                var list = subset.ToList();
                list.Sort();
                if (res.Any(r => r.SequenceEqual(list)))
                    return;
                res.Add(list); 
                return;
            }
            subset.Add(nums[i]);
            Dfs( i + 1);
            subset.RemoveAt(subset.Count - 1); 
            Dfs(i + 1);
        }
    }
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> subset = new List<int>();
        Array.Sort(nums);
        Backtrack(0);
        return res;

        void Backtrack(int i)
        {
            if (i == nums.Length)
            {
                res.Add(subset.ToList());
                return;
            }
            
            subset.Add(nums[i]);
            Backtrack(i+1);
            subset.RemoveAt(subset.Count -1);

            while (i+1 < nums.Length && nums[i] == nums[i+1]) 
                i+=1;
            Backtrack(i+1);
        }
    }
}