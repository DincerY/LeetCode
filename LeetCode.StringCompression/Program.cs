Solution solution = new();
solution.Compress(new []{'a','a','b','b','c','c','c'});
solution.Compress(new []{'a','b','b','b','b','b','b','b','b','b','b'});


Console.WriteLine("Hello, World!");


public class Solution {
    public int Compress(char[] chars)
    {
        int left = 0;
        int right = 0;
        //it represents index that chars array has
        int index = 0;
        while(right <= chars.Length)
        {
            if (right < chars.Length && chars[left] == chars[right])
            {
                right++;
            }
            else
            {
                int count = right - left;
                //if we have 2 digit decimal, this version will not work
                if (count != 1)
                {
                    chars[index + 1] = (char)count;
                }
                left = right;
                index+=2;
                if (right == chars.Length)
                {
                    break;
                }
            }
        }
        return index;
    }
    
}