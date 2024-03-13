Solution solution = new();
// solution.PlusOne3(new[]
// {
//     6,1,4,5,3,9,0,1,9,5,1,8,6,7,0,5,5,4,3
// });
solution.PlusOne3(new[]
{ 
    3
});


Console.WriteLine("Hello, World!");




public partial class Solution {
    /// <summary>
    /// Bu çözüm çalışmıyor
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] PlusOne(int[] digits)
    {
        int lastIndex = digits.Length - 1;
        int sum = digits[lastIndex] + 1;
        if (sum > 9)
        {
            sum = sum % 10;
            digits[lastIndex - 1]++;
            digits[lastIndex] = sum;
        }  
        digits[lastIndex] = sum;

        lastIndex--;

        while (digits[lastIndex] > 9)
        {
            sum = sum % 10;
            digits[lastIndex - 1]++;
            digits[lastIndex] = sum;
            lastIndex--;
        }

        return digits;
    }
}


public partial class Solution {
    /// <summary>
    /// Bu çözüm çalışmıyor
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] PlusOne2(int[] digits)
    {
        List<int> arr = new List<int>();
        long result = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            result += digits[i];
            result *= 10;
        }

        result /= 10;
        result++;

        string deneme = result.ToString();

        for (int i = 0; i < deneme.Length; i++)
        {
            arr.Add(deneme[i] - 48);
        }

        return arr.ToArray();
    }
}

public partial class Solution {
    public int[] PlusOne3(int[] digits)
    {
        int lastIndex = digits.Length - 1;
        if (lastIndex > 0)
        {
            int sum = digits[lastIndex] + 1;
            if (sum > 9)
            {
                digits[lastIndex - 1]++;
                digits[lastIndex] = 0;
            }
            else
            {
                digits[lastIndex] = sum;
            }

            lastIndex--;

        }
        else
        {
            digits[lastIndex]++;
        }
      
        while (digits[lastIndex] > 9)
        {
            if (lastIndex - 1 < 0)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }
            else
            {
                digits[lastIndex - 1]++;
                digits[lastIndex] = 0;
                lastIndex--;
            }
        }

        return digits;
    }
}
