Solution solution = new();
solution.HammingWeight2(11);

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int HammingWeight(int n)
    {
        int count = 0;
        int val = (int)Math.Log2(n) + 1;  
        for (int i = val; i >= 0; i--)
        {
            if ((n & (1 << i)) != 0)
            {
                count++;
            }
        }
        return count;
    }
}

public partial class Solution
{
    public int HammingWeight2(int n)
    {
        int count = 0;
        while (n != 0)
        {
            n &= (n - 1);
            count++;
        }
        return count;
    }
}