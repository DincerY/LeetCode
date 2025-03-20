Solution solution = new();
solution.MinDays(10);
solution.MinDays(6);

Console.WriteLine("Hello, World!");


public partial class Solution {
    public int MinDays(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        int min = 10000000;
        void Backtrack(int val,int days)
        {
            if (val == 0)
            {
                min = Math.Min(min, days);
                return;
            }
            Backtrack(val-1,days+1);
            if (val % 3 == 0)
            {
                Backtrack(val -((val / 3) * 2),days+1);
            }

            if (val % 2 == 0)
            {
                Backtrack(val - (val/2),days+1);
            }
        }
        Backtrack(n,0);
        return min;
    }
}


public partial class Solution {
    public int MinDays2(int n)
    {
        return 0;
    }
}