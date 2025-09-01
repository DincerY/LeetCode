Solution solution = new();
solution.ReverseVowels2("IceCreAm");
solution.ReverseVowels2(".,");

Console.WriteLine("Hello, World!");


public class Solution
{
    public string ReverseVowels2(string s)
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
}