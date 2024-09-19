Solution solution = new();
solution.reverseBits(43261596);


Console.WriteLine("Hello, World!");


public class Solution
{
    public uint reverseBits(uint n)
    {
        List<int> list = new();
        for (int i = 31; i >= 0; i--)
        {
            if ((n & (1 << i)) != 0)
                list.Add(1);
            else
                list.Add(0);
        }
        list.Reverse();
        int[] bitArr = list.ToArray();
        string binaryString = string.Join("", bitArr);
        return Convert.ToUInt32(binaryString, 2);
    }
}