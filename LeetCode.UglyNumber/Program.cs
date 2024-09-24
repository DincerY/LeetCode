Solution solution = new();
solution.IsUgly(14);
solution.IsUgly(1);
solution.IsUgly(6);



Console.WriteLine("Hello, World!");


public class Solution
{
    public bool IsUgly(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        List<int> list = new(){2,3,5};
        foreach (var val in list)
        {
            while (n % val == 0)
            {
                n /= val;
            }
        }
        return n == 1;
    }
}