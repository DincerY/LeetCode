Solution solution = new();
solution.Compress2(new []{'a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a',});

solution.Compress2(new []{'a','a','a','b','b','a','a'});

solution.Compress2(new []{'a','a','b','b','c','c','c'});
solution.Compress2(new []{'a','b','b','b','b','b','b','b','b','b','b'});


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
        int i = 0;
        int res = 0;
        while (i < chars.Length)
        {
            var chr = chars[i];
            int groupLength = 1;
            while (i + groupLength < chars.Length && chars[i + groupLength] == chars[i])
            {
                groupLength++;
            }
            chars[res] = chr;
            res++;
            if (groupLength > 1)
            {
                foreach(var digit in groupLength.ToString())
                {
                    chars[res] = digit;
                    res++;
                }
            }
            i += groupLength;
        }
        return res;
    }
}