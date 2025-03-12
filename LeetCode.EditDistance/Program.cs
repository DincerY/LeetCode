Solution solution = new();
solution.MinDistance3("horse", "ros");
solution.MinDistance3("intention", "execution");

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
        int min = 1000;
        void Backtrack(int i, int j, int val)
        {
            if (i == word1.Length && j == word2.Length)
            {
                min = Math.Min(min, val);
                return;
            }
            if (i == word1.Length || j == word2.Length)
            {
                return;
            }
            if (word1[i] == word2[j])
            {
                Backtrack(i+1,j+1,val);
            }
            else
            { 
                Backtrack(i,j+1,val+1); //Insert
                Backtrack(i+1,j+1,val+1); //Replace
                Backtrack(i+1,j,val+1); //Delete
            }
        }
        Backtrack(0,0,0);
        return min;
    }
}


public partial class Solution
{
    public int MinDistance3(string word1, string word2)
    {
        int min = int.MaxValue;
        void Backtrack(int word1Index,int word2Index,int op)
        {
            if (word1Index >= word1.Length || word2Index >= word2.Length)
            {
                if (word2Index >= word2.Length)
                {
                    min += word1Index - word2Index;
                }
                if (word1Index >= word1.Length && word2Index >= word2.Length)
                {
                    min = Math.Min(min, op);
                }
                return;
            }
            if (word1[word1Index] == word2[word2Index])
            {
                Backtrack(word1Index+1,word2Index+1,op);
            }
            else
            {
                Backtrack(word1Index,word2Index+1,op+1); //Insert
                Backtrack(word1Index+1,word2Index,op+1); //Delete
                Backtrack(word1Index+1,word2Index+1,op+1); //Replace
            }
        }
        Backtrack(0,0,0);
        return min;
    }
}
