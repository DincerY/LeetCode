Solution solution = new();
solution.MinDistance("horse", "ros");
solution.MinDistance("intention", "execution");


Console.WriteLine("Hello, World!");


//NeedCode's solution
public partial class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int[,] cache = new int[word1.Length + 1, word2.Length + 1];

        for (int i = 0; i <= word2.Length; i++)
        {
            cache[word1.Length, i] = word2.Length - i;
        }
        for (int j = 0; j <= word1.Length; j++)
        {
            cache[j, word2.Length] = word1.Length - j;
        }

        for (int i = word1.Length - 1; i >= 0; i--)
        {
            for (int j = word2.Length - 1; j >= 0; j--)
            {
                if (word1[i] == word2[j])
                {
                    cache[i, j] = cache[i + 1, j + 1];
                }
                else
                {
                    cache[i, j] = 1 + Math.Min(cache[i + 1, j], Math.Min(cache[i, j + 1], cache[i + 1, j + 1]));
                }
            }
        }
        return cache[0, 0];
    }
}



public partial class Solution
{
    public int MinDistance2(string word1, string word2)
    {
        return 0;
    }
}
