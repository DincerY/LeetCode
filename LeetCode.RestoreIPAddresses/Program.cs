Solution solution = new();
solution.RestoreIpAddresses("25525511135");

Console.WriteLine("Hello, World!");



public class Solution {
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> result = new();
        int dotSum = 0;
        if (s.Length > 12)
        {
            return null;
        }
        void Recursion(string sub,int n,int dot)
        {
            dotSum += dot;
            if (dotSum == s.Length)
            {
                Console.WriteLine("Başarılı");
                result.Add(sub);
            }
            //Buralardan emin değilim
            sub += s.Substring(dotSum, dot);
            sub = "";
            if (n < 4)
            {
                Recursion(sub,n+1,1);
                dotSum-=1;
                Recursion(sub,n+1, 2);
                dotSum-=2;
                Recursion(sub,n+1 ,3);
                dotSum-=3;

            }
           
        }
        
        Recursion(s[0].ToString(),0,0);

        return null;
    }
}