// See https://aka.ms/new-console-template for more information
Solution solution = new();
solution.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
Console.WriteLine("Hello, World!");


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string,int> dictionary = new Dictionary<string, int>();
        List<IList<string>> result = new List<IList<string>>();
        List<string> sub = new List<string>();

        foreach (var str in strs)
        {
            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                total = total + (int)str[i];
            }
            dictionary.Add(str,total);
        }


        //sub.Add();
        //result.Add();
        
        return result;
    }
}












