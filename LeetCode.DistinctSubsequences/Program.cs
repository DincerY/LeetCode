Solution solution = new();
//solution.NumDistinct2("rabbbit", "rabbit");
//solution.NumDistinct("babgbag", "bag");



var a = solution.NumDistinct2("adbdadeecadeadeccaeaabdabdbcdabddddabcaaadbabaaedeeddeaeebcdeabcaaaeeaeeabcddcebddebeebedaecccbdcbcedbdaeaedcdebeecdaaedaacadbdccabddaddacdddc", "bcddceeeebecbc");
Console.WriteLine(a);



Console.WriteLine("Hello, World!");

//It is true but not efficient so it is brute force solution
public partial class Solution
{
    public int NumDistinct(string s, string t)
    {
        int val = 0;  
        bool isFor = false;
        void Recursion(int idx, int tidx)
        {
            for (int i = idx; i < s.Length; i++)
            {
                if (tidx == t.Length)
                {
                    val++;
                    isFor = true;
                    break;
                }
                if (s[i] == t[tidx])
                {
                    Recursion(i +1, tidx +1);
                    
                } 
            }
            if (!isFor && tidx == t.Length)
            {
                val++;
            }
            isFor = false;
        }
        Recursion(0,0);
        return val;
    }
}


//it is not mine solution
public partial class Solution
{
    public int NumDistinct2(string s, string t) {
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();

        int Dfs(int i, int j) {
            if (j == t.Length) {
                return 1;
            }
            if (i == s.Length) {
                return 0;
            }
            if (cache.ContainsKey((i, j))) {
                return cache[(i, j)];
            }

            if (s[i] == t[j]) {
                cache[(i, j)] = Dfs(i + 1, j + 1) + Dfs(i + 1, j);
            } else {
                cache[(i, j)] = Dfs(i + 1, j);
            }
            return cache[(i, j)];
        }

        return Dfs(0, 0);
    }
}
