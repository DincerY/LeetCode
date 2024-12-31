Solution solution = new();
solution.Change3(5, new[] { 1, 2, 5 });
solution.Change3(3, new[] { 2 });
solution.Change3(10, new[] { 10 });


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
        int[] res = new int[coins.Length + 1];
        for (int i = 1; i < coins.Length+1; i++)
        {
            
        }



        return 0;
    }
}