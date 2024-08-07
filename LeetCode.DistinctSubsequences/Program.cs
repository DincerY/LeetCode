Solution solution = new();
solution.NumDistinct("rabbbit", "rabbit");



Console.WriteLine("Hello, World!");


public class Solution
{
    public int NumDistinct(string s, string t)
    {
        void Recursion(int idx, int tidx)
        {
            for (int i = idx; i < s.Length; i++)
            {
                if (s[i] == t[tidx])
                {
                    Recursion(i +1, tidx +1);
                    
                } 
            }
            
                
        }
        Recursion(0,0);
        return 0;
    }
}