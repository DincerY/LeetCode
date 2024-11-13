Solution solution = new();

solution.DivisorGame(2);
solution.DivisorGame(6);

Console.WriteLine("Hello, World!");


public class Solution
{
    public bool DivisorGame(int n)
    {
        bool[] arr = new bool[n];

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (arr[i] == true)
                {
                    break;
                }
                if ((i + 1) % j == 0)
                {
                    arr[i] = !arr[i - j];
                }
            }
        }
        return arr[^1];
    }
}