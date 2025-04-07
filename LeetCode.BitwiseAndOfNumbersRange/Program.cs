Solution solution = new();
solution.RangeBitwiseAnd(5,7);
solution.RangeBitwiseAnd(0,0);
solution.RangeBitwiseAnd(1,2147483647);

Console.WriteLine("Hello, World!");



public partial class Solution {
    public int RangeBitwiseAnd(int left, int right)
    {
        int res = left;
        for (int i = left+1; i <= right; i++)
        {
            res &= i;
        }
        return res;
    }
}