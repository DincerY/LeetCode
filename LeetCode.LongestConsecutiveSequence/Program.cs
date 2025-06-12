using System.ComponentModel;

Solution solution = new();
solution.LongestConsecutive3(new[] { 100, 4, 200, 1, 3, 2 });
solution.LongestConsecutive3(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
solution.LongestConsecutive3(new[] { 1, 2, 0, 1 });


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        int max = 0;
        int temp = 0;
        Array.Sort(nums);
        List<int> list = new();
        list.Add(nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                list.Add(nums[i]);
            }
        }

        nums = list.ToArray();
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == 1)
            {
                temp++;
            }
            else
            {
                max = Math.Max(max, temp);
                temp = 0;
            }
        }

        max = Math.Max(max, temp);

        return max + 1;
    }
}

public partial class Solution
{
    public int LongestConsecutive2(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        Array.Sort(nums);
        Dictionary<int, int> dic = new();
        foreach (var num in nums)
        {
            if (!dic.ContainsKey(num - 1))
            {
                dic.TryAdd(num, 1);
            }
            else
            {
                dic.TryAdd(num, dic[num - 1] + 1);
            }
        }
        return dic.Select(kv => kv.Value).Max();
    }
}


public partial class Solution
{
    public int LongestConsecutive3(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;
        foreach (int n in numSet)
        {
            if (!numSet.Contains(n - 1))
            {
                int length = 1;
                while (numSet.Contains(n + length))
                {
                    length++;
                }

                longest = Math.Max(length, longest);
            }
        }
        return longest;
    }
}

public partial class Solution
{
    public int LongestConsecutive4(int[] nums)
    {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        int max = 1;
        int cur = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1])
            {
                continue;
            }
            else if (nums[i] == nums[i - 1] + 1)
            {
                cur++;
            }
            else
            {
                max = Math.Max(max, cur);
                cur = 1;
            }
        }
        return Math.Max(max, cur);
    }
}