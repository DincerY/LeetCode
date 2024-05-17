Solution solution = new();
// solution.Merge(new []
// {
//     2,5,6
// },3, new []
// {
//     1,2,3,0,0,0
// },3);


solution.Merge(new[]
{
    0
}, 0, new[]
{
    1
}, 1);


Console.WriteLine("Hello, World!");


public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int j = 0;

        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[j];
            j++;
        }

        Array.Sort(nums1);
    }
}