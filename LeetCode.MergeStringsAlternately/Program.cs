using System.Text;

Solution solution = new();
solution.MergeAlternately("abc", "pqr");


Console.WriteLine("Hello, World!");


public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder builder = new();
        int word1Pointer = 1;
        builder.Append(word1[0]);
        int word2Pointer = 0;
        
        int len1 = word1.Length;
        int len2 = word2.Length;

        while (word1Pointer < len1 && word2Pointer < len2)
        {
            if (word1Pointer > word2Pointer)
            {
                builder.Append(word2[word2Pointer]);
                word2Pointer++;
            }
            else
            {
                builder.Append(word1[word1Pointer]);
                word1Pointer++;
            }
        }

        while (word1Pointer < len1)
        {
            builder.Append(word1[word1Pointer]);
            word1Pointer++;
        }
        while (word2Pointer < len2)
        {
            builder.Append(word2[word2Pointer]);
            word2Pointer++;
        }

        return builder.ToString();
    }
}