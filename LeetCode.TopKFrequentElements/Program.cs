using System.Collections.Immutable;

Solution solution = new();
solution.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);
solution.TopKFrequent(new[] { 3, 3, 3, 2, 2, 1 }, 2);
solution.TopKFrequent(new[] { 3, 0, 1, 0 }, 2);

Console.WriteLine("Hello, World!");

public class Solution
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