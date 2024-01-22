Solution solution = new();
solution.Permute(new[] { 1, 2, 3 ,4,5});
Console.WriteLine("");


public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> onePermutation = new List<int>();
        Recursion(nums,onePermutation,result);
        return result;
    }

    private void Recursion(int[] nums,List<int> onePermutation,List<IList<int>> result)
    {
        if (onePermutation.Count == nums.Length)
        {
            result.Add(new List<int>(onePermutation));
            return;
        }
        foreach (var num in nums)
        {
            if (onePermutation.Contains(num)) continue;
            onePermutation.Add(num);
            Recursion(nums,onePermutation,result);
            onePermutation.RemoveAt(onePermutation.Count-1);
        }   
    }
}       