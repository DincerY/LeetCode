using System.Text;

Solution solution = new();
solution.MergeAlternately("abc", "pqr");


Console.WriteLine("Hello, World!");


public partial class Solution
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

public partial class Solution
{
    public string MergeAlternately2(string word1, string word2)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int i = 0;
        int j = 0;
        int len1 = word1.Length;
        int len2 = word2.Length;

        while (i < len1 || j < len2)
        {
            if (i < len1)
            {
                stringBuilder.Append(word1[i]);
                i++;
            }
            if (j < len2)
            {
                stringBuilder.Append(word2[j]);
                j++;
            }
        }
        return stringBuilder.ToString();
    }
}

public partial class Solution
{
    public string MergeAlternately3(string word1, string word2)
    {
        List<char> chars = new List<char>();
        int len1 = word1.Length;
        int len2 = word2.Length;

        int maxLen = Math.Max(len1, len2);

        for (int i = 0; i < maxLen; i++)
        {
            if (i < len1)
            {
                chars.Add(word1[i]);
            }
            if (i < len2)
            {
                chars.Add(word2[i]);
            }
        }

        return new string(chars.ToArray());
    }
}