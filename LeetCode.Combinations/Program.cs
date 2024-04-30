Solution solution = new();

solution.Combine(5, 3);


Console.WriteLine("Hello, World!");



public partial class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        List<IList<int>> res = new();
        Recursion(new List<int>(), 1);
        return res;

        void Recursion(List<int> combination, int first)
        {
            if (combination.Count == k)
            {
                res.Add(new List<int>(combination));
                return;
            }
            
            for (int i = first; i < n+1; i++)
            {
                combination.Add(i);
                Recursion(combination,i+1);
                combination.Remove(i);
            }
        }
        
    }
}