Solution solution = new();
//solution.LengthOfLastWord("Hello World");
solution.LengthOfLastWord3("   fly me   to   the moon  ");


Console.WriteLine("Hello, World!");





public partial class Solution {
    public int LengthOfLastWord(string s)
    {
        return s.Trim(' ').Split(' ')[^1].Length;
    }
}

public partial class Solution {
    //This is not my solution
    public int LengthOfLastWord2(string s)
    {
        s = s.Trim();
        string lastWord = s.Substring(s.LastIndexOf(' ') + 1);
        return lastWord.Length;
    }
}

public partial class Solution {
    public int LengthOfLastWord3(string s)
    {
        int i = s.Length - 1;
        int length = 0;
        while (s[i] == ' ')
        {
            i -= 1;
        }
        while (i >= 0 && s[i] != ' ')
        {
            length += 1;
            i--;
        }
        return length;
    }
}
