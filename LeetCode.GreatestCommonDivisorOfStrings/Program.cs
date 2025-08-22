Solution solution = new();
solution.GcdOfStrings("ABCABC", "ABC");

Console.WriteLine("Hello, World!");

public class Solution {
    public string GcdOfStrings(string str1, string str2)
    {
        for (int i = 1; i < str1.Length; i++)
        {
            var prefix = str1.Substring(0,i);

            for (int j = 0; j < str1.Length; j+=i)
            {
                if (prefix != str1.Substring(j,i))
                {
                    break;
                }
            }
        }
        return "";
    }
}