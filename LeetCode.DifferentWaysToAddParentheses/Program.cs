Solution solution = new();
//solution.DiffWaysToCompute("2-1-1");
solution.DiffWaysToCompute("2*3-4*5");

Console.WriteLine("Hello, World!");

//it is not mine solution
public class Solution {
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