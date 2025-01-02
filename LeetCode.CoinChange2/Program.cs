using System.Runtime.Intrinsics.Arm;

Solution solution = new();
solution.Change4(5, new[] { 1, 2, 5 });
solution.Change4(3, new[] { 2 });
solution.Change4(10, new[] { 10 });


Console.WriteLine("Hello, World!");


//Worked but time limit exceeded
public partial class Solution
{
    public int Change(int amount, int[] coins)
    {
        int res = 0;

        void Backtrack(int total, int last)
        {
            if (total > amount)
            {
                return;
            }

            if (total == amount)
            {
                res++;
                return;
            }

            for (int i = last; i < coins.Length; i++)
            {
                Backtrack(total + coins[i], i);
            }
        }

        Backtrack(0, 0);
        return res;
    }
}


//NeedCode solution

public partial class Solution
{
    public int Change2(int amount, int[] coins)
    {
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        for (int i = coins.Length - 1; i >= 0; i--)
        {
            int[] nextDP = new int[amount + 1];
            nextDP[0] = 1;
            for (int a = 1; a <= amount; a++)
            {
                nextDP[a] = dp[a];
                if (a - coins[i] >= 0)
                {
                    nextDP[a] += nextDP[a - coins[i]];
                }
            }

            dp = nextDP;
        }

        return dp[amount];
    }
}


public partial class Solution
{
    public int Change3(int amount, int[] coins)
    {
        int length = 0;

        void Backtrack(int total, int index)
        {
            if (total >= amount)
            {
                if (total == amount)
                {
                    length++;
                }

                return;
            }

            for (int i = index; i < coins.Length; i++)
            {
                Backtrack(total + coins[i], i);
            }
        }

        Backtrack(0, 0);
        return length;
    }
}

public partial class Solution
{
    public int Change4(int amount, int[] coins)
    {
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();

        int Backtrack(int i, int a)
        {
            if (a == amount)
            {
                return 1;
            }
            if (a > amount)
            {
                return 0;
            }
            if (i == coins.Length)
            {
                return 0;
            }
            if (cache.ContainsKey((i, a)))
            {
                return cache[(i, a)];
            }
            cache[(i, a)] = Backtrack(i, a + coins[i]) + Backtrack(i + 1, a);
            return cache[(i, a)];
        }
        return Backtrack(0, 0);
    }
}
//for kullanınca neden hata aldık bunu anlamaya çalışalım
public partial class Solution
{
    public int Change3Dp(int amount, int[] coins)
    {
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
        int Backtrack(int total, int index)
        {
            if (total == amount)
            {
                return 1;
            }
            if (total > amount)
            {
                return 0;
            }
            if (index == coins.Length)
            {
                return 0;
            }
            if (cache.ContainsKey((index,total)))
            {
                return cache[(index, total)];
            }
            int length = 0;
            for (int i = index; i < coins.Length; i++)
            {
                length += Backtrack(total + coins[i], i);
            }

            cache[(index, total)] = length;
            return length;
        }
        return Backtrack(0, 0);
    }
}