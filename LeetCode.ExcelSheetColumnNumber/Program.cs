Solution solution = new();
solution.TitleToNumber("A");
solution.TitleToNumber("AB");
solution.TitleToNumber("ZY");

Console.WriteLine("Hello, World!");


public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int total = 0;
        foreach (var chr in columnTitle)
        {
            if (total != 0) 
                total *= 26;
            total += chr - 64;
        }
        return total;
    }
}