using System.Collections.Immutable;

Solution solution = new();
solution.TopKFrequent2(new[] { 1, 1, 1, 2, 2, 3 }, 2);
solution.TopKFrequent(new[] { 3, 3, 3, 2, 2, 1 }, 2);
solution.TopKFrequent(new[] { 3, 0, 1, 0 }, 2);

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        List<int> list = new();
        Dictionary<int, int> dic = new();
        foreach (var num in nums)
        {
            if (!dic.ContainsKey(num))
            {
                dic.Add(num,1);
            }
            else
            {
                dic[num]++;
            }
        }
        int i = 0;
        foreach (var kv in dic.OrderByDescending(kv => kv.Value))
        {
            if (i == k)
            {
                break;
            }
            list.Add(kv.Key);
            i++;
        }
        return list.ToArray();
    }
}

//NeedCode solution
public partial class Solution {
    public int[] TopKFrequent2(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];

        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach (var n in nums) {
            count[n] = 1 + (count.ContainsKey(n) ? count[n] : 0);
        }
        foreach (var kvp in count) {
            freq[kvp.Value].Add(kvp.Key);
        }

        var res = new List<int>();
        for (int i = freq.Length - 1; i > 0; i--) {
            res.AddRange(freq[i]);
            if (res.Count == k) {
                return res.ToArray();
            }
        }
        return res.ToArray();
    }
}
