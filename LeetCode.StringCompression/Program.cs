Solution solution = new();
solution.Compress(new []{'a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a',});

solution.Compress(new []{'a','a','a','b','b','a','a'});

solution.Compress(new []{'a','a','b','b','c','c','c'});
solution.Compress(new []{'a','b','b','b','b','b','b','b','b','b','b'});


Console.WriteLine("Hello, World!");


public class Solution {
    public int Compress(char[] chars)
    {
        if (chars.Length == 1)
        {
            return 1;
        }
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
                chars[index] = chars[left];
                if (count != 1)
                {
                    var str = count.ToString();
                    foreach (var chr in str)
                    {
                        chars[index + 1] = chr;
                        index++;
                    }
                }
                left = right;
                index++;
                if (right == chars.Length)
                {
                    break;
                }
            }
        }
        return index;
    }
    public int Compress2(char[] chars)
    {
        return 0;
    }
}