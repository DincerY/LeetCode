Solution solution = new();
solution.IsHappy(19);
solution.IsHappy(2);

Console.WriteLine("Hello, World!");


public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> set = new HashSet<int>();
        while (n != 1)
        {
            int temp = n;
            n = 0;
            while (temp > 0)
            {
                n += (int)Math.Pow(temp % 10,2);
                temp /= 10;
            }

            if (set.Contains(n))
            {
                return false;
            }
            else
            {
                set.Add(n);
            }
        }
        return true;
    }
}