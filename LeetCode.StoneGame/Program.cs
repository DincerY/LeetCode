Solution solution = new();
solution.StoneGame(new[] { 5, 3, 4, 5 });

solution.StoneGame2(new[] { 3,7,2,3 });

solution.StoneGame2(new[] { 5,1,100,6 });

Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public bool StoneGame(int[] piles)
    {
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Dfs(int l, int r)
        {
            if (l > r)
            {
                return 0;
            }

            if (dp.ContainsKey((l, r)))
            {
                return dp[(l, r)];
            }

            bool even = (r - 1) % 2 == 0;
            int left = even ? piles[l] : 0;
            int right = even ? piles[r] : 0;

            dp[(l, r)] = Math.Max(Dfs(l + 1, r) + 
                                  left, Dfs(l, r - 1) + right);
            return dp[(l, r)];
        }
        return Dfs(0, piles.Length - 1) > (piles.Sum() / 2);
    }
}


//it is not work
public partial class Solution
{
    public bool StoneGame2(int[] piles)
    {
        List<int> pileList = piles.ToList();
        int aliceGreater = 0;
        void Backtrack(bool isAlice, int aliceVal ,List<int> list)
        {
            if (list.Count <= 0)
            {
                aliceGreater = Math.Max(aliceGreater, aliceVal);
                return;
            }

            int value = list[0];
            var temp = list.ToList();
            temp.RemoveAt(0);
            int alice = aliceVal;

            if (isAlice)
            {
                alice += value;
            }
           
            
            Backtrack(!isAlice, alice, temp);
            
            value = list[^1];
            list.RemoveAt(list.Count()-1);
            Backtrack(!isAlice, alice ,list);
            
        }
        Backtrack(true, 0,pileList);
        return aliceGreater > (piles.Sum() / 2);
    }
    
}