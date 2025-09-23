Solution solution = new();
solution.MaxOperations2(new[] { 1, 2, 3, 4 }, 5);
solution.MaxOperations2(new[] { 3, 1, 3, 4, 3 }, 6);
Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;
        int res = 0;
        while (left < right)
        {
            int total = nums[left] + nums[right];
            if (total == k)
            {
                left++;
                right--;
                res++;
            }
            else if (total < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return res;
    }
}
public partial class Solution
{
    public int MaxOperations2(int[] nums, int k)
    {
        Dictionary<int, int> dic = new();
        int count = 0;
        foreach (var num in nums)
        {
            int val = k - num;
            if (dic.ContainsKey(val))
            {
                dic[val]--;
                if (dic[val] == 0)
                {
                    dic.Remove(val);
                }

                count++;
            }
            else
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num,1);
                }
            }
        }
        return count;
    }
}