Solution solution = new();
solution.MaxCoins(new[] { 3, 1, 5, 8 });

Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaxCoins(int[] nums)
    {
        int res = 0;
        void Recursion(List<int> list)
        {
            int amount = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (i -1 >= 0)
                {
                    amount *= list[i - 1];
                }

                if (i+1 < list.Count)
                {
                    amount *= list[i + 1];
                }
                
                amount *= list[i];
                list.RemoveAt(i);
                Recursion(list.ToList());
            }
        }
        Recursion(new List<int>(nums));
        return 0;
    }
}