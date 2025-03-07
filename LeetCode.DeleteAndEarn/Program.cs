Solution solution = new();
//solution.DeleteAndEarn(new[] { 3, 4, 2 });
//solution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
//solution.DeleteAndEarn(new[] { 3,7,10,5,2,4,8,9,9,4,9,2,6,4,6,5,4,7,6,10 });

solution.DeleteAndEarn4(new[] { 2, 2, 3, 3, 3, 4 });

solution.DeleteAndEarn4(new[] { 2, 3, 3, 5, 7, 7 });
solution.DeleteAndEarn2(new[] { 1});


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution {
    public int DeleteAndEarn(int[] nums) {
        var count = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (count.ContainsKey(num)) {
                count[num]++;
            } else {
                count[num] = 1;
            }
        }

        var uniqueNums = count.Keys.ToList();
        uniqueNums.Sort();

        int earn1 = 0, earn2 = 0;
        for (int i = 0; i < uniqueNums.Count; i++) {
            int curEarn = uniqueNums[i] * count[uniqueNums[i]];

            if (i > 0 && uniqueNums[i] == uniqueNums[i - 1] + 1) {
                int temp = earn2;
                earn2 = Math.Max(curEarn + earn1, earn2);
                earn1 = temp;
            } else {
                int temp = earn2;
                earn2 = curEarn + earn2;
                earn1 = temp;
            }
        }
        return earn2;
    }
}

public partial class Solution
{
    public List<List<int>> combinations = new List<List<int>>();

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
}


//Brute force
public partial class Solution
{
    public int DeleteAndEarn2(int[] nums)
    {
        Array.Sort(nums);
        Dictionary<int, int> dic = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i],1);
            }
        }
        var arr = dic.Keys.ToArray();
        int max = 0;
        void Backtrack(int index, int total,int lastAdded)
        {
            if (index >= arr.Length)
            {
                max = Math.Max(max, total);
                return;
            }

            if (lastAdded + 1 != arr[index])
            {
                Backtrack(index +1, total+ (arr[index] * dic[arr[index]]),arr[index]);
            }
            Backtrack(index +1, total,lastAdded);
        }
        Backtrack(0,0,-1);
        return max;
    }
}

//Dynamic programming
public partial class Solution
{
    public int DeleteAndEarn3(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        Array.Sort(nums);
        Dictionary<int, int> dic = new();
        var arr = Helper(dic, nums);
        
        int[] dp = new int[arr.Length];
        dp[^1] = arr[^1] * dic[arr[^1]];
        for (int i = arr.Length-2; i >= 0; i--)
        {
            if (arr[i]+1 != arr[i+1])
            {
                dp[i] = (dic[arr[i]] * arr[i]) + dp[i + 1];
            }
            else
            {
                int nextVal = i + 2 < arr.Length ? dp[i+2] : 0;
                dp[i] = Math.Max(dic[arr[i]] * arr[i] + nextVal, dp[i + 1]);
            }
        }

        return dp[0];
    }

    private int[] Helper(Dictionary<int,int> dic, int[] nums)
    {
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
        }

        return dic.Keys.ToArray();
    }
}
//Dynamic programming with no memory
public partial class Solution
{
    public int DeleteAndEarn4(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        Array.Sort(nums);
        Dictionary<int, int> dic = new();
        var arr = Helper(dic, nums);
        
        int left = arr[^1] * dic[arr[^1]];
        int right = 0;
        for (int i = arr.Length-2; i >= 0; i--)
        {
            int temp = left;
            if (arr[i]+1 != arr[i+1])
            {
                left += (dic[arr[i]] * arr[i]);
                right = temp;
            }
            else
            {
                left = Math.Max(dic[arr[i]] * arr[i] + right, left);
                right = temp;
            }
        }
        return left;
    }
}










