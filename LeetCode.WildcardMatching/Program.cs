namespace LeetCode.WildcardMatching
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.IsMatch("ab", "?b");



        }
    }
    
    public class Solution {
        public bool IsMatch(string s, string p)
        {
            int skipNumber = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    char a = p[i + 1];
                }
                else if (p[i] == '?')
                {
                    skipNumber++;
                    return s[i + skipNumber] == p[i + skipNumber];
                }
                else
                {
                    return s[i] == p[i];
                }
            }


            return true;
        }
    }
}