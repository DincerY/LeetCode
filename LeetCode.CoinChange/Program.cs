Solution solution = new();
/*solution.CoinChange2(new[] { 1, 2, 5 }, 11);
solution.CoinChange2(new[] { 2 }, 3);
solution.CoinChange2(new[] { 1 }, 0);*/

solution.CoinChange3(new[] { 2 }, 3);
solution.CoinChange3(new[] { 1, 3, 4, 5 }, 7);
solution.CoinChange2(new[] { 1, 2, 5 }, 11);
//solution.CoinChange2(new[] { 186,419,83,408 }, 6249);


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        for (int i = 1; i < amount + 1; i++)
        {
            dp[i] = amount + 1;
        }

        for (int a = 1; a < dp.Length; a++)
        {
            foreach (var c in coins)
            {
                if (a - c >= 0)
                {
                    dp[a] = Math.Min(dp[a], 1 + dp[a - c]);
                }
            }
        }

        return dp[amount] != amount + 1 ? dp[amount] : -1;
    }
}

public partial class Solution
{
    //Daha sonra algoritmayı bitirdiğimde büyükten küçüğe sıralanmış hali ile deneyelim
    public int CoinChange2(int[] coins, int amount)
    {
        List<int> amounts = new List<int>();

        void Backtrack(int total, int coin)
        {
            if (total >= amount)
            {
                if (total == amount)
                {
                    amounts.Add(coin);
                }

                return;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                Backtrack(total + coins[i], coin + 1);
            }
        }

        Backtrack(0, 0);


        //Not work
        /*Array.Sort(coins);
        int i = coins.Length - 1;
        while (i >= 0)
        {
            int totalCoin = 0;
            int total = 0;
            int temp = amount;
            int j = i;
            while (j >= 0)
            {
                if (coins[j] <= temp)
                {
                    temp -= coins[j];
                    total += coins[j];
                    totalCoin++;
                }
                else
                {
                    j--;
                }
            }
            if (total == amount)
            {
                return totalCoin;
            }

            i--;
        }*/
        Console.WriteLine(amounts.Min());
        return -1;
    }
    
    
    public int CoinChange3(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        
        for (int i = 1; i <= amount; i++)
        {
            dp[i] = 1000000;
            foreach (var coin in coins)
            {
                if (i - coin >= 0)
                {
                    dp[i] = Math.Min(dp[i],dp[i - coin] + 1);
                }
            }
        }
        return dp[amount] == 1000000 ? -1 : dp[amount];
    }
}