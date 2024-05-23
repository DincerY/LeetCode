Solution solution = new();
solution.GrayCode(3);

Console.WriteLine("Hello, World!");


public class Solution {
    public IList<int> GrayCode(int n)
    {
        if (n == 1)
            return new List<int>() { 0, 1 };
        
        IList<int> recursion = GrayCode(n - 1);
        IList<int> temp = new List<int>();
        
        for (int i = 0; i < recursion.Count; i++) 
            temp.Add(recursion[i]);
        // for (int i = 0; i < recursion.Count; i++) 
        //     temp.Add(0<<n-1 | recursion[i]);

        for (int i = recursion.Count-1; i >= 0; i--)
            temp.Add(1<<n-1 | recursion[i]);
        return temp;
    }    
}



