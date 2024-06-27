Solution solution = new();
solution.NumTrees(5);


Console.WriteLine("Hello, World!");


public class Solution {
    public int NumTrees(int n)
    {
        Dictionary<int, int> dic = new(); 
        dic.Add(0,0);
        dic.Add(1,1);
        Recursion(n);

        void Recursion(int n)
        {
            int total = 0;
            if (!dic.ContainsKey(n))
            {   
                Recursion(n-1);
                if (dic.ContainsKey(n))
                {   
                    int maxVal = n + 1; 
                    for (int i = 1; i <= maxVal; i++)  
                    {
                        int left = i - 1;
                        if (left == 0)
                        {
                            left = 1;
                        }
                        int right = maxVal - i;
                        if (right == 0)
                        {
                            right = 1;
                        }
                        dic.TryGetValue(left, out left);
                        dic.TryGetValue(right, out right);
                        total += left * right;
                    }
                    dic.TryAdd(n + 1, total);
                }
            }
            else
            {
                int maxVal = n + 1; 
                for (int i = 1; i <= maxVal; i++)  
                {
                    int left = i - 1;
                    if (left == 0)
                    {
                        left = 1;
                    }
                    int right = maxVal - i;
                    if (right == 0)
                    {
                        right = 1;
                    }
                    dic.TryGetValue(left, out left);
                    dic.TryGetValue(right, out right);
                    total += left * right;
                }
            
                dic.TryAdd(n + 1, total);
            }
        }

        int result = 0;
        dic.TryGetValue(n, out result);
        return result;
    }
}