Solution solution = new();
//solution.DeleteAndEarn(new[] { 3, 4, 2 });
//solution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
//solution.DeleteAndEarn(new[] { 3,7,10,5,2,4,8,9,9,4,9,2,6,4,6,5,4,7,6,10 });

solution.GenerateCombinations2(new[] { 2, 3, 5, 7 },0, new List<int>());


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int DeleteAndEarn(int[] nums)
    {
        int res = 0;
        Array.Sort(nums);
        Dictionary<int, int> dp = new();
        List<int> list = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!list.Contains(nums[i]))
            {
                list.Add(nums[i]);
            }

            if (dp.ContainsKey(nums[i]))
            {
                dp[nums[i]]++;
            }
            else
            {
                dp.Add(nums[i], 1);
            }
        }

        return res;
    }
}


public partial class Solution
{
    public List<List<int>> combinations = new List<List<int>>();


    public void Recursion(int[] arr, int index, List<int> cur, List<List<int>> all)
    {
        all.Add(cur.ToList());

        for (int i = index; i < arr.Length; i++)
        {
            cur.Add(arr[i]);
            Recursion(arr, i + 1, cur, all);

            cur.RemoveAt(cur.Count - 1);
        }
    }

    public void GenerateCombinations(int[] arr, int index, List<int> current)
    {
        if (index == arr.Length)
        {
            combinations.Add(current.ToList());
            return;
        }

        current.Add(arr[index]);
        GenerateCombinations(arr, index + 1, current);

        current.RemoveAt(current.Count - 1);

        GenerateCombinations(arr, index + 1, current);
    }
    
    public void GenerateCombinations2(int[] arr, int index, List<int> combination)
    {
        if (index == arr.Length)
        {
            combinations.Add(combination.ToList());
            return;
        }

        for (int i = index; i < arr.Length; i++)
        {
            combination.Add(arr[i]);
            GenerateCombinations2(arr, i + 1, combination);
            combination.Remove(arr[i]);
        }
    }
}