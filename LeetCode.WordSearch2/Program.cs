Solution solution = new();
solution.FindWords(new[]
{
    new[] { 'o', 'a', 'a', 'n' },
    new[] { 'e', 't', 'a', 'e' },
    new[] { 'i', 'h', 'k', 'r' },
    new[] { 'i', 'f', 'l', 'v' },
}, new[] { "oath", "pea", "eat", "rain" });

Console.WriteLine("Hello, World!");
//NeedCode solution
public class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; set; }
    public bool IsWord { get; set; }
    public int Refs { get; set; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsWord = false;
        Refs = 0;
    }

    public void AddWord(string word)
    {
        TrieNode cur = this;
        cur.Refs++;
        foreach (char c in word)
        {
            if (!cur.Children.ContainsKey(c))
            {
                cur.Children[c] = new TrieNode();
            }
            cur = cur.Children[c];
            cur.Refs++;
        }
        cur.IsWord = true;
    }

    public void RemoveWord(string word)
    {
        TrieNode cur = this;
        cur.Refs--;
        foreach (char c in word)
        {
            if (cur.Children.ContainsKey(c))
            {
                cur = cur.Children[c];
                cur.Refs--;
            }
        }
    }
}

public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        TrieNode root = new TrieNode();
        foreach (string w in words)
        {
            root.AddWord(w);
        }

        int ROWS = board.Length, COLS = board[0].Length;
        HashSet<string> res = new HashSet<string>();
        HashSet<(int, int)> visit = new HashSet<(int, int)>();

        void Dfs(int r, int c, TrieNode node, string word)
        {
            if (r < 0 || r >= ROWS || c < 0 || c >= COLS ||
                !node.Children.ContainsKey(board[r][c]) ||
                node.Children[board[r][c]].Refs < 1 ||
                visit.Contains((r, c)))
            {
                return;
            }

            visit.Add((r, c));
            node = node.Children[board[r][c]];
            word += board[r][c];
            if (node.IsWord)
            {
                node.IsWord = false;
                res.Add(word);
                root.RemoveWord(word);
            }

            Dfs(r + 1, c, node, word);
            Dfs(r - 1, c, node, word);
            Dfs(r, c + 1, node, word);
            Dfs(r, c - 1, node, word);
            visit.Remove((r, c));
        }

        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                Dfs(r, c, root, "");
            }
        }

        return new List<string>(res);
    }
}

