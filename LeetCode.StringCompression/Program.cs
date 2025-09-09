Solution solution = new();
solution.Compress(new []{'a','a','b','b','c','c','c'});

Console.WriteLine("Hello, World!");


public class Solution {
    public int Compress(char[] chars)
    {
        int left = 0;
        int right = 0;
        //it represents index that chars array has
        int index = 0;
        while(right < chars.Length)
        {
            if (chars[left] == chars[right])
            {
                right++;
            }
            else
            {
                int count = right - left;
                left = right;
            }
        }
        return 0;
    }
}