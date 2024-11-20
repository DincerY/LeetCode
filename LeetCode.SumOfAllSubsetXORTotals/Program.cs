Solution solution = new();
solution.SubsetXORSum(new[] { 1, 3 });

Console.WriteLine("Hello, World!");

public partial class Solution
{
    List<List<int>> subset = new List<List<int>>();
    public int SubsetXORSum(int[] nums)
    {
        Combination(nums,0,new List<int>());

        List<int> res = new List<int>();
        int xorVal = 0;
        foreach (var list in subset)
        {
            foreach (var val in list)
            {
                xorVal = val ^ xorVal;
            }
            res.Add(xorVal);
            xorVal = 0;
        }
        return res.Sum();
    }
    private void Combination(int[] nums,int index,List<int> list)
    {
        if (index == nums.Length)
        {
            subset.Add(list.ToList());
            return;
        }

        var temp = list.ToList();
        temp.Add(nums[index]);
        Combination(nums,index+1,temp);
        Combination(nums,index+1,list);

    }
}

//More efficient
public partial class Solution
{
    List<int> all = new List<int>();
    public int SubsetXORSum2(int[] nums)
    {
        Combination2(nums,0,0);
        return all.Sum();
    }
    
    private void Combination2(int[] nums,int index,int com)
    {
        if (index == nums.Length)
        {   
            all.Add(com);
            return;
        }
        int temp = com;
        com ^= nums[index];
        Combination2(nums,index+1,com);
        Combination2(nums,index+1,temp);
    }
    
}