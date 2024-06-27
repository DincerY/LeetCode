Solution solution = new();
solution.IsInterleave2("aabcc", "dbbca", "aadbbcbcac");



Console.WriteLine("Hello, World!");



public partial class Solution {
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int s1Index = 0;
        int s2Index = 0;

        foreach (var value in s3)
        {
            if (s1Index < s1.Length && s1[s1Index] == value)
            {
                s1Index++;
            }
            else if(s2Index < s2.Length && s2[s2Index] == value)
            {
                s2Index++;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}


public partial class Solution {
    public bool IsInterleave2(string s1, string s2, string s3)
    {
        //bütün harflerin sayılarını tutan bir tablo oluşturup s3 içinde hepsinin var olup olmadığına bakıcam
        Dictionary<char, int> dic = new();
        foreach (var val in s1)
        {
            int outValue = 0;
            dic.TryGetValue(val, out outValue);
            if (outValue == 0)
            {
                outValue = 1;
            }

            dic.TryAdd(val, outValue);
            dic.Add(val,outValue);
        }   


        return true;
    }
}