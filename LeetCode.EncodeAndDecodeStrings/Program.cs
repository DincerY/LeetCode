using System.Text;

Solution solution = new();
var res = solution.Encode2(new List<string>()
{
    "lint","code","love","you"
});

solution.Decode2(res);


Console.WriteLine("Hello, World!");


public partial class Solution
{
    private const char markedValue = '-';
    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0)
        {
            return null;
        }
        StringBuilder builder = new();
        for (int i = 0; i < strs.Count; i++)
        {
            if (i != strs.Count - 1)
            {
                builder.Append(strs[i] + markedValue);
            }
            else
            {
                builder.Append(strs[i]);
            }
        }
        return builder.ToString();
    }

    public List<string> Decode(string s)
    {
        if (s == null)
        {
            return new List<string>();
        }
        if (s == "")
        {
            return new List<string>(){""};
        }
        var res = s.Split(markedValue);
        return res.ToList();
    }
}

public partial class Solution
{
    public string Encode2(IList<string> strs)
    {
        if (strs.Count == 0)
        {
            return null;
        }
        StringBuilder builder = new();
        foreach (var str in strs)
        {
            builder.Append(str.Length + (markedValue + str));
        }
        
        return builder.ToString();
    }

    public List<string> Decode2(string s)
    {
        if (s == null)
        {
            return new List<string>();
        }
        if (s == "")
        {
            return new List<string>(){""};
        }
        
        return res;
    }
}