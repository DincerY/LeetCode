Solution solution = new();
solution.Change(5, new[] { 1, 2, 5 });


Console.WriteLine("Hello, World!");


public class Solution
{
    public int Change(int amount, int[] coins)
    {

        void Backtrack(int total,int c)
        {
            if (total >= amount)
            {
                return;
            }

            total += c;

            foreach (var coin in coins)
            {
                Backtrack(total,coin);
            }
        }
        Backtrack(0,0);


        return 0;
    }
}