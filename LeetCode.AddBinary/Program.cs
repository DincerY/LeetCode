Solution solution = new();
solution.AddBinary("1111", "1111");


Console.WriteLine("Hello, World!");


public class Solution
{
    /// <summary>
    /// Devamında charların sayı değerlerini hesaplıcam.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public string AddBinary(string a, string b)
    {
        int length = Math.Max(a.Length, b.Length);
        int inta = int.Parse(a);
        int intb = int.Parse(b);

        var intResult = inta + intb;
        

        var result = (inta + intb).ToString().ToCharArray();

        for (int i = length - 1; i >= 0; i--)
        {
            if (result[i] >= 50)
            {
                if (i-1 < 0)
                {
                    result[0] = '0';
                    List<char> newChar = new List<char>(length +1);
                    newChar.Add('1');
                    newChar.AddRange(result);
                    var charArr = newChar.ToArray();
                    return new string(charArr);
                }
                else
                {
                    result[i] = '0';
                    if (result[i - 1] == '1')
                    {
                        result[i - 1] = '2';
                    }
                    else if (result[i -1] == '2')
                    {
                        result[i -1] = '3';
                    }
                    else
                    {
                        result[i - 1] = '1';
                    }
                }
            }
        }

        return new string(result);
    }
}