Solution solution = new();
solution.SimplifyPath("/../");


Console.WriteLine("Hello, World!");



public class Solution {
    public string SimplifyPath(string path)
    {
        Stack<char> stack = new();
        for (int i = 0; i < path.Length; i++)
        {
            if (i == path.Length-1 && path[i] == '/')
            {
                continue;
            }

            stack.TryPeek(out char a);
            if (a == '/')
            {
                
                if (path[i] == '/')
                {
                    continue;
                }

                if (path[i] == '.')
                {
                    stack.Pop();
                    continue;
                }
            }

            if (path[i] == '.')
            {
                char ss;
                stack.TryPeek(out ss);
                if (ss == '\0')
                {
                    continue;
                }
                while (ss != '/')
                {
                    stack.Pop();
                    stack.TryPeek(out ss);
                }

                stack.Pop();
            }
            stack.Push(path[i]);
        }

        var deneme = "stack.ToString()";
        var enumerable = deneme.Reverse();
        return deneme;
    }


   
}