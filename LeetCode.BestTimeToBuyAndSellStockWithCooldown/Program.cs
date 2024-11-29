Solution solution = new();
solution.MaxProfit2(new[] { 1, 2, 3, 0, 2 });
solution.MaxProfit2(new[] { 1, 2,4 });

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

public partial class Solution
{
    
    enum State
    {
        Buy, Sell
    }
    //Bir kere cooldown olduktan sonra alış yapabilmem gerekiyor onun takibini yapmıyorum
    public int MaxProfit2(int[] prices)
    {
        int max = 0;
        void Dfs(State lastState,int index,int total)
        {
            if (index == prices.Length)
            {
                max = Math.Max(max,total);
                return;
            }
            
            if (lastState == State.Sell)
            {
                Dfs(State.Buy,index+1,total-prices[index]);
                Dfs(lastState,index+1,total);
            }
            else
            {
                Dfs(lastState,index+1,total);
            }
            

        }
        Dfs(State.Sell,0,0);
        return max;
    }
}