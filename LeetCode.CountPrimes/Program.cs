Solution solution = new();
solution.CountPrimes2(10);
solution.CountPrimes(2);
solution.CountPrimes(0);
solution.CountPrimes(1);

Console.WriteLine("Hello, World!");

//Time limit exceeded
public partial class Solution
{
    public int CountPrimes(int n)
    {
        int count = 0;
        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }
        return count;
    }
    private bool IsPrime(int val)
    {
        for (int i = 2; i < val; i++)
        {
            if (val % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}


public partial class Solution
{
    public int CountPrimes2(int n)
    {
        bool[] list = new bool[n];
        Array.Fill(list,true,0,n);
        int sqrt = (int)Math.Sqrt(n);
        for (int i = 2; i <= sqrt; i++)
        {
            if (list[i])
            {
                for (int j = 2; j < n; j++)
                {
                    if (i * j < n)
                    {
                        list[i * j] = false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        int res = 0;
        for (int i = 2; i < list.Length; i++)
        {
            if (list[i])
            {
                res++;
            }
        }
        return res;
    }
}