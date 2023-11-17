using System.Linq;

namespace LeetCode.FindTheIndexOf
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            // solution.StrStr("mississippi", "sippi");
            solution.Str("mississippi", "sippi");
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            int l = 0;
            for (int r = 0; r < haystack.Length; r++)
            {
                if (r + needle.Length > haystack.Length)
                {
                    return -1;
                }

                if (haystack[r] == needle[0])
                {
                    for (int i = r; i < r + needle.Length; i++)
                    {
                        if (haystack[i] == needle[l])
                        {
                            l++;
                        }
                        else
                        {
                            l = 0;
                            break;
                        }

                        if (l == needle.Length)
                        {
                            return r;
                        }
                    }
                }
            }

            if (l == 0)
            {
                return -1;
            }

            return l;
        }


        public int Str(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                string result = "";
                if (i + needle.Length > haystack.Length)
                {
                    return -1;
                }
                if (haystack[i] == needle[0])
                {
                    for (int j = 0; j < needle.Length; j++)
                    {
                        result += haystack[i+j];
                    }

                }
                if (result == needle)
                {
                    return i;
                }
            }
            
            return 0;
        }
    }
}



























