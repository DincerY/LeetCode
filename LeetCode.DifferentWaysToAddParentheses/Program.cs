Solution solution = new();
//solution.DiffWaysToCompute("2-1-1");
solution.DiffWaysToCompute2("2*3-4*5");

Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
{
    public IList<int> DiffWaysToCompute2(string expression)
    {
        var operations = new Dictionary<string, Func<int, int, int>>
        {
            { "+", (x, y) => x + y },
            { "-", (x, y) => x - y },
            { "*", (x, y) => x * y }
        };

        IList<int> Backtrack(int left, int right)
        {
            var res = new List<int>();

            for (int i = left; i <= right; i++)
            {
                var op = expression[i].ToString();
                if (operations.ContainsKey(op))
                {
                    var nums1 = Backtrack(left, i - 1);
                    var nums2 = Backtrack(i + 1, right);

                    foreach (var n1 in nums1)
                    {
                        foreach (var n2 in nums2)
                        {
                            res.Add(operations[op](n1, n2));
                        }
                    }
                }
            }
            if (res.Count == 0)
            {
                res.Add(int.Parse(expression.Substring(left, right - left + 1)));
            }
            return res;
        }
        return Backtrack(0, expression.Length - 1);
    }
}