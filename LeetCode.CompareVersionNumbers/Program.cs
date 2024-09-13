Solution solution = new();
//solution.CompareVersion("1.2", "1.10");
//solution.CompareVersion("1.0", "1.0.0.0");
solution.CompareVersion("1.0.1", "1");


Console.WriteLine("Hello, World!");

//it is not mine
public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        int N1 = v1.Length;
        int N2 = v2.Length;

        for (int i = 0; i < Math.Max(N1, N2); i++)
        {
            int n1 = (i >= N1) ? 0 : int.Parse(v1[i]);
            int n2 = (i >= N2) ? 0 : int.Parse(v2[i]);

            if (n1 > n2)
            {
                return 1;
            }
            else if (n1 < n2)
            {
                return -1;
            }
        }
        return 0;
    }
}