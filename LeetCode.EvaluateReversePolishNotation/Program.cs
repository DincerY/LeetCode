Solution solution = new Solution();
solution.EvalRPN(new[]
{
    "2", "1", "+", "3", "*"
});
solution.EvalRPN(new[]
{
    "4", "13", "5", "/", "+"
});

solution.EvalRPN(new[]
{
    "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"
});


Console.WriteLine("Hello, World!");


public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();
        int total = 0;
        foreach (var token in tokens)
        {
            int val;
            if (int.TryParse(token, out val))
            {
                stack.Push(val);
            }
            else
            {
                int val1 = stack.Pop();
                int val2 = stack.Pop();
                switch (token)
                {
                    case "+":
                        total = val1 + val2;
                        break;
                    case "-":
                        total = val2 - val1;
                        break;
                    case "*":
                        total = val1 * val2;
                        break;
                    case "/":
                        total = val2 / val1;
                        break;
                }
                stack.Push(total);
            }
        }
        return stack.Pop();
    }
}