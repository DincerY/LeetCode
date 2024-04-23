Solution solution = new();
solution.MinWindow("ADOBECODEBANC", "ABC");



Console.WriteLine("Hello, World!");



public class Solution {
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> dic = new();
        //bu değişken s nin içinde ki bir diğer t değişkeninin başlagıç indexinin tutucak
        int leftPointer = 0;
        for (int i = 0; i < t.Length; i++)
        {
            dic.Add(t[i],0);
        }
        
        
        
        
        
        
        List<string> result = new();
        string temp = "CAHASB";
        int a = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (temp.Any(c => c == t[i]))
            {
                a++;
            }
        }
        

        return "";
    }
}