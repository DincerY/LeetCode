Solution solution = new();
solution.IsPowerOfTwo2(1);
solution.IsPowerOfTwo2(16);
solution.IsPowerOfTwo2(3);
solution.IsPowerOfTwo2(-100);

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        string a = Convert.ToString(n, 2);
        if (a.Count(c => c == '1') == 1)
        {
            return true;
        }
        
        return false;
    }
}
//NeedCode solution
public partial class Solution
{
    public bool IsPowerOfTwo2(int n)
    {
        int x = 1;
        while (x < n)
        {
            x *= 2;
        }
        return x == n;
    }
}
public partial class Solution
{
    public bool IsPowerOfTwo3(int n)
    {
        //Is there 0 after the dot
        var a = Math.Log(n, 2);
        return true;
    }
}