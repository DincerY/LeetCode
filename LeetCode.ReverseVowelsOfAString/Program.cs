Solution solution = new();
solution.ReverseVowels("IceCreAm");
solution.ReverseVowels(".,");

Console.WriteLine("Hello, World!");


public class Solution
{
    public string ReverseVowels(string s)
    {
        var result = s.ToArray();
        List<char> vowels = new()
        {
            'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'
        };
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            if (!vowels.Contains(s[i]))
            {
                i++;
                continue;
            }

            if (!vowels.Contains(s[j]))
            {
                j--;
                continue;
            }
            (result[i], result[j]) = (result[j], result[i]);
            i++;
            j--;
        }
        return string.Join("", result);
    }
    
    public string ReverseVowels2(string s)
    {
        List<char> vowels = new()
        {
            'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'
        };
        List<int> index = new List<int>();
        List<char> chars = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < vowels.Count; j++)
            {
                if (s[i] == vowels[j])
                {
                    index.Add(i);
                    chars.Add(vowels[j]);
                }
            }
        }

        var sArray = s.ToArray();
        chars.Reverse();
        for (int i = 0; i < index.Count; i++)
        {
            sArray[index[i]] = chars[i];
        }

        return string.Join("", sArray);
    }
}