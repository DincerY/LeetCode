Solution solution = new();
/*solution.Rob(new []
{
    2,7,9,3,1
});

solution.Rob(new []
{
    2,1,1,2
});*/

solution.Rob4(new [] { 1,2,3,1 });

solution.Rob4(new [] { 2,7,9,3,1 });

Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public int Rob(int[] nums)
    {
        int rob1 = 0;
        int rob2 = 0;
        foreach (var n in nums)
        {
            int temp = Math.Max(n + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }
        return rob2;
    }
}

//Brute force
public partial class Solution
{
    public int Rob2(int[] nums)
    {
        int max = int.MinValue;
        void Backtrack(int index, int value,bool skip)
        {
            if (index == nums.Length)
            {
                max = Math.Max(max, value);
                return;
            }

            if (skip)
            {
                Backtrack(index+1, value+nums[index],false);
            }
            Backtrack(index+1,value, true);

        }
        Backtrack(0, 0,true);
        return max;
    }
}

//Dynamic programing
public partial class Solution
{
    public int Rob3(int[] nums)
    {
        int[] res = new int[nums.Length+1];
        res[^2] = nums[^1];

        for (int i = nums.Length-2; i >= 0; i--)
        {
            res[i] = Math.Max(res[i + 1], nums[i] + res[i+2]);
        }

        return res[0];
    }
}

//Dynamic programing 2 elems
public partial class Solution
{
    public int Rob4(int[] nums)
    {
        int left = 0;
        int right = 0;

        for (int i = nums.Length-1; i >= 0; i--)
        {
            var curr = nums[i] + (i + 2 < nums.Length ? right : 0);
            right = left;
            left = Math.Max(curr,left);
        }

        return left;
    }
}