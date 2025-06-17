Solution solution = new();
solution.TwoSum3(new[]
{
    2, 7, 11, 15
}, 9);

solution.TwoSum2(new[]
{
    -10, -8, -2, 1, 2, 5,
}, 0);

solution.TwoSum2(new[]
{
    1, 3, 4, 5, 7, 10, 11
}, 9);

solution.TwoSum2(new[]
{
    -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 8
}, 9);

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] res = new int[2];
        int maxLen = numbers.Length;
        for (int i = 0; i < maxLen; i++)
        {
            for (int j = i + 1; j < maxLen; j++)
            {
                if (numbers[i] + numbers[j] > target)
                {
                    maxLen = j;
                    break;
                }

                if (numbers[i] + numbers[j] == target)
                {
                    res[0] = i + 1;
                    res[1] = j + 1;
                    return res;
                }
            }
        }

        return res;
    }
}

public partial class Solution
{
    public int[] TwoSum2(int[] numbers, int target)
    {
        int[] res = new int[2];
        int l = 0;
        int r = numbers.Length - 1;
        while (numbers[l] + numbers[r] != target)
        {
            if (numbers[l] + numbers[r] > target)
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        res[0] = l + 1;
        res[1] = r + 1;
        return res;
    }
}
public partial class Solution
{
    public int[] TwoSum3(int[] numbers, int target)
    {
        Dictionary<int, int> dic = new();
        for (int i = 0; i < numbers.Length; i++)
        {
            int dif = target - numbers[i];
            if (dic.ContainsKey(dif))
            {
                return new[] { dic[dif], i+1 };
            }

            if (!dic.ContainsKey(numbers[i]))
            {
                dic.Add(numbers[i],i+1);
            }
        }
        return new[] { -1, -1 };
    }
}