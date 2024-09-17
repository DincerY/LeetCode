Solution solution = new();
solution.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");

Console.WriteLine("Hello, World!");

//it is not mine solution
public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        HashSet<string> seen = new HashSet<string>();
        HashSet<string> res = new HashSet<string>();
        for (int l = 0; l < s.Length - 9; l++)
        {
            string cur = s.Substring(l, 10);
            if (seen.Contains(cur))
            {
                res.Add(cur);
            }

            seen.Add(cur);
        }

        return new List<string>(res);
    }
}