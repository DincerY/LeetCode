Solution solution = new();
solution.MajorityElement2(new[] { 2,2,1,3 });

solution.MajorityElement2(new[] { 3, 2, 3 });
solution.MajorityElement2(new[] { 1,1,2,2,2,2,3,3,3,3,3,3});
solution.MajorityElement2(new[] { 1 });
solution.MajorityElement2(new[] { 1, 2 });

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        List<int> res = new();
        Dictionary<int, int> dic = new();
        foreach (var num in nums)
        {
            if (dic.ContainsKey(num))
            {
                dic[num]++;
            }
            else
            {
                dic.Add(num,1);
            }
            if (!res.Contains(num) && dic[num] > nums.Length / 3)
            {
                res.Add(num);   
            }
        }
        return res;
    }
}

public partial class Solution
{
    public IList<int> MajorityElement2(int[] nums)
    {
        var count = new Dictionary<int, int>();
        
        foreach (var n in nums)
        {
            if (count.ContainsKey(n))
            {
                count[n]++;
            }
            else
            {
                count[n] = 1;
            }
            
            if (count.Count <= 2)
            {
                continue;
            }
            var newCount = new Dictionary<int, int>();
            foreach (var kvp in count)
            {
                if (kvp.Value > 1)
                {
                    newCount[kvp.Key] = kvp.Value - 1;
                }
            }
            count = newCount;
        }
        
        var res = new List<int>();
        foreach (var n in count.Keys)
        {
            if (nums.Count(x => x == n) > nums.Length / 3)
            {
                res.Add(n);
            }
        }
        return res;
    }
}