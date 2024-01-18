Solution solution = new();
solution.Permute(new []{1,2,3});
Console.WriteLine("");



public class Solution {
    public IList<IList<int>> Permute(int[] nums)
    {
        List<int> onePermutation = new List<int>();
        void Recursion(int s)
        {
            s++;
            if (s < nums.Length)
            {
                onePermutation.Add(nums[s]);
                Recursion(s);
                Recursion(s+1);
            }
     
        }
        
        Recursion(0);

        return null;
    }
}