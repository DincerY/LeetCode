Solution solution = new();
//solution.SimplifyPath3("/home//foo/..");
//solution.SimplifyPath3("/abc/...");
solution.SimplifyPath3("/a/./b/../../c/");



//solution.SimplifyPath2("/home/");
//solution.SimplifyPath2("/a/../../b/../c//.//");


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public string SimplifyPath(string path)
    {
        Stack<char> stack = new();
        for (int i = 0; i < path.Length; i++)
        {
            if (i == path.Length - 1 && path[i] == '/')
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

            if (path[i] != '.')
            {
                stack.Push(path[i]);
            }
        }

        //stack.TryPop(out char b);
        string deneme = "";

        while (stack.TryPop(out char a))
        {
            deneme += a;
        }

        char[] arr = deneme.ToCharArray();

        if (arr.Length < 1)
        {
            return "/";
        }

        Array.Reverse(arr);
        return new string(arr);
    }
}

public partial class Solution
{
    public string SimplifyPath2(string path)
    {
        Stack<string> stack = new();
        for (int i = 1; i < path.Length-1; i++)
        {
            if (path[i] != '/' && path[i] != '.')
            {
                int j = i;
                string deneme = "";
                while (path[j] != '/')
                {
                    deneme += path[j];
                    j++;
                }

                i = j;
                stack.Push(deneme);
            }

            if (path[i] == '.' && path[i + 1] == '.')
            {
                stack.TryPop(out string b);
            }
        }
        string result = "";
        while (stack.Count > 0)
        {
            stack.TryPop(out string a);
            result = "/" +a + result;
        }
        if (result == "")
            return "/";
        return result;
    }
}

public partial class Solution
{
    public string SimplifyPath3(string path)
    {
        Stack<string> stack = new();
        string curr = "";
        for (int i = 1; i < path.Length; i++)
        {
            while (i < path.Length && path[i] != '/')
            {
                curr += path[i];
                i++;
            }
            if (curr != "")
            {
                if (curr == "..")
                    stack.TryPop(out string b);
                else if (curr == ".")
                {
                    //not
                }
                else
                    stack.Push(curr);
                curr = "";
            }
        }
        //return string.Join("/", stack.Reverse());
        curr = "";
        while (stack.Count > 0)
        {
            stack.TryPop(out string a);
            curr = "/" +a + curr;
        }
        if (curr == "")
            return "/";
        return curr;
    }
}


