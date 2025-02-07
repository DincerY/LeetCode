Solution solution = new();
solution.MaxAlternatingSum4(new[] { 4, 2, 5, 3 });
solution.MaxAlternatingSum4(new[] { 5, 6, 7, 8 });
solution.MaxAlternatingSum4(new[] { 6, 2, 1, 2, 4, 5});


Console.WriteLine("Hello, World!");


//LeetCode solution
//too hard
public partial class Solution
{
    public long MaxAlternatingSum(int[] nums)
    {
        Dictionary<(int, bool), long> dp = new Dictionary<(int, bool), long>();

        long Dfs(int i, bool even)
        {
            if (i == nums.Length)
            {
                return 0;
            }

            if (dp.ContainsKey((i, even)))
            {
                return dp[(i, even)];
            }

            int total = even ? nums[i] : -nums[i];
            dp[(i, even)] = Math.Max(total + Dfs(i + 1, !even), Dfs(i + 1, even));
            return dp[(i, even)];
        }

        return Dfs(0, true);
    }
}

public partial class Solution
{
    public long MaxAlternatingSum2(int[] nums)
    {
        long sumEven = 0, sumOdd = 0;

        for (int i = nums.Count() - 1; i >= 0; i--)
        {
            long tmpEven = Math.Max(sumOdd + nums[i], sumEven);
            long tmpOdd = Math.Max(sumEven - nums[i], sumOdd);
            sumEven = tmpEven;
            sumOdd = tmpOdd;
        }

        return sumEven;
    }
}



//Brute force approach
public partial class Solution
{
    public long MaxAlternatingSum3(int[] nums)
    {
        List<List<int>> list = new();
        void Backtrack(List<int> arr,int index)
        {
            if (index == nums.Length)
            {
                list.Add(arr.ToList());
                return;
            }
            arr.Add(nums[index]);
            Backtrack(arr,index+1);
            arr.RemoveAt(arr.Count-1);
            Backtrack(arr,index+1);
        }
        Backtrack(new List<int>(),0);

        int max = -1;
        foreach (var combination in list)
        {
            int temp = 0;
            for (int i = 0; i < combination.Count; i++)
            {
                if (i % 2 == 0)
                {
                    temp += combination[i];
                }
                else
                {
                    temp -= combination[i];
                }
            }

            max = Math.Max(max, temp);
        }
        return max;
    }
}

public partial class Solution
{
    public long MaxAlternatingSum4(int[] nums)
    {
        int max = -1;
        void Backtrack(int val,int index, bool isPositive)
        {
            if (index == nums.Length)
            {
                max = Math.Max(max, val);
                return;
            }

            int temp = isPositive ? val + nums[index] : val - nums[index];
            Backtrack(temp,index+1,!isPositive);
            Backtrack(val,index+1,isPositive);
        }
        Backtrack(0,0,true);
        return max;
    }
}
















