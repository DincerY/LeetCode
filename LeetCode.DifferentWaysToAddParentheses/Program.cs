Solution solution = new();
//solution.DiffWaysToCompute("2-1-1");
solution.DiffWaysToCompute2("2*3-4*5");

Console.WriteLine("Hello, World!");

//it is not mine solution
public partial class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        IList<int> res = new List<int>();
        for (int i = 0; i < expression.Length; i++) {
            char oper = expression[i];
            if (oper == '+' || oper == '-' || oper == '*') {
                IList<int> s1 = DiffWaysToCompute(expression.Substring(0, i));
                IList<int> s2 = DiffWaysToCompute(expression.Substring(i + 1));
                foreach (int a in s1) {
                    foreach (int b in s2) {
                        if (oper == '+') res.Add(a + b);
                        else if (oper == '-') res.Add(a - b);
                        else if (oper == '*') res.Add(a * b);
                    }
                }
            }
        }
        if (res.Count == 0) res.Add(Int32.Parse(expression));
        return res;
    }
}

//NeedCode solution
public partial class Solution
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