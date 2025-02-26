Solution solution = new();
solution.MaxProfit5(new[] { 1, 2, 3, 0, 2 });
solution.MaxProfit5(new[] { 1, 2, 4 });

Console.WriteLine("Hello, World!");

//NeedCode solution 
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        Dictionary<(int, bool), int> dp = new Dictionary<(int, bool), int>();

        int Dfs(int i, bool buying)
        {
            if (i >= prices.Length)
            {
                return 0;
            }

            if (dp.ContainsKey((i, buying)))
            {
                return dp[(i, buying)];
            }

            int cooldown = Dfs(i + 1, buying);
            if (buying)
            {
                int buy = Dfs(i + 1, !buying) - prices[i];
                dp[(i, buying)] = Math.Max(buy, cooldown);
            }
            else
            {
                int sell = Dfs(i + 2, !buying) + prices[i];
                dp[(i, buying)] = Math.Max(sell, cooldown);
            }

            return dp[(i, buying)];
        }

        return Dfs(0, true);
    }
}


//Working but time limit exceeded
public partial class Solution
{
    enum State
    {
        Sell,
        Buy,
        Cooldown
    }

    public int MaxProfit2(int[] prices)
    {
        int max = 0;

        void Dfs(State state, int index, int total)
        {
            if (index == prices.Length)
            {
                max = Math.Max(max, total);
                return;
            }

            if (state == State.Sell)
            {
                Dfs(State.Cooldown, index + 1, total);
            }
            else if (state == State.Cooldown)
            {
                Dfs(State.Buy, index + 1, total - prices[index]);
                Dfs(State.Cooldown, index + 1, total);
            }
            else
            {
                Dfs(State.Sell, index + 1, total + prices[index]);
                Dfs(state, index + 1, total);
            }
        }

        Dfs(State.Cooldown, 0, 0);
        return max;
    }
}

//Dp solution. More effective
public partial class Solution
{
    public int MaxProfit3(int[] prices)
    {
        Dictionary<(int, bool), int> dp = new Dictionary<(int, bool), int>();
        int Dfs(int i, bool buying)
        {
            if (i >= prices.Length)
            {
                return 0;
            }
            if (dp.ContainsKey((i, buying)))
            {
                return dp[(i, buying)];
            }
            //int cooldown = Dfs(i + 1, buying);
            if (buying)
            {
                int buy = Dfs(i + 1, !buying) - prices[i];
                int cooldown = Dfs(i + 1, buying);
                dp[(i, buying)] = Math.Max(buy, cooldown);
            }
            else
            {
                int sell = Dfs(i + 2, !buying) + prices[i];
                int cooldown = Dfs(i + 1, buying);
                dp[(i, buying)] = Math.Max(sell, cooldown);
            }
            return dp[(i, buying)];
        }
        return Dfs(0, true);
    }
}



public partial class Solution
{
    public int MaxProfit4(int[] prices)
    {
        int max = 0;
        void Backtrack(int index,bool isBuying,int total)
        {
            if (index >= prices.Length)
            {
                max = Math.Max(max, total);
                return;
            }
            if (isBuying)
            {
                Backtrack(index+1, !isBuying, total-prices[index]);
                Backtrack(index+1,isBuying, total);
            }
            else
            {
                Backtrack(index+2, !isBuying, total+prices[index]);
                Backtrack(index+1,isBuying,total);
            }
            
        }
        Backtrack(0,true,0);
        return max;
    }
}

public partial class Solution
{
    public int MaxProfit5(int[] prices)
    {
        Dictionary<(int, bool), int> dp = new();
        int Backtrack(int index,bool isBuying)
        {
            if (index >= prices.Length)
            {
                return 0;
            }

            if (dp.ContainsKey((index,isBuying)))
            {
                return dp[(index, isBuying)];
            }
            
            if (isBuying)
            {
                int buy = Math.Max(Backtrack(index + 1, !isBuying) - prices[index], 
                    Backtrack(index + 1, isBuying));
                dp.Add((index,isBuying),buy);
            }
            else
            {
                int sell = Math.Max(Backtrack(index + 2, !isBuying) + prices[index], 
                    Backtrack(index + 1, isBuying));
                dp.Add((index,isBuying),sell);
            }

            return dp[(index, isBuying)];
        }
        return Backtrack(0,true);
    }
}