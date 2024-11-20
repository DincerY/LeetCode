Solution solution = new();
solution.NthUglyNumber(3, 2, 3, 5);
solution.NthUglyNumber(4, 2, 3, 4);

Console.WriteLine("Hello, World!");

//time limit exceeded
public class Solution
{
    public int NthUglyNumber(int n, int a, int b, int c)
    {
        int count = 0;
        int i = a;
        while (true)
        {
            if (i % a == 0  || i % b == 0 || i % c == 0)
            {
                count++;
            }
            if (count == n)
            {
                return i;
            }
            i++;
        }
    }
}