Solution solution = new();
solution.Subsets2(new[]
{
    1, 2, 3
});


Console.WriteLine("Hello, World!");


public partial class Solution {
    public IList<IList<int>> Subsets(int[] nums)
    {
        //n elemenlı bir kümenin 2^n elemanlı alt kümesi vardır
        IList<IList<int>> res = new List<IList<int>>();
        for (int i = 1; i < nums.Length; i++)
        {
            Recursion(i,0, new List<int>());
        }
        //döngüyü boş elemanı ve bütün elemanları doldurmak için bir kez daha döndürmek istemedim
        res.Add(new List<int>());
        res.Add(new List<int>(nums));
        return res;

        void Recursion(int value,int count, List<int> temp)
        {
            if (temp.Count == value)
            {
                res.Add(new List<int>(temp));
                return;
            }
            
            for (int i = count; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                Recursion(value,i+1,temp);
                temp.Remove(nums[i]);
            }
        }            
    }
}


public partial class Solution {
    /// <summary>
    /// it is not mine
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Subsets2(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> subset = new List<int>();
        Dfs(0);
        return res;
        
        void Dfs(int i)
        {
            if (i == nums.Length)
            {
                res.Add(subset.ToList()); 
                return;
            }

            subset.Add(nums[i]);
            Dfs( i + 1);
            subset.RemoveAt(subset.Count - 1); 

            Dfs(i + 1);
        }
    }

    
}