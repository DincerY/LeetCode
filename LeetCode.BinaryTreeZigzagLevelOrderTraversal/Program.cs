Solution solution = new Solution();
solution.ZigzagLevelOrder(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));


solution.BFS(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));


Console.WriteLine("Hello, World!");


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public partial class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> list = new();

        void Zigzag()
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> currStack = new();
            Stack<TreeNode> nextStack = new();
        
            currStack.Push(root);
            bool leftToRight = true;
            List<int> levelList = new();

            while (currStack.Count > 0)
            {
                TreeNode curr = currStack.Pop();
                levelList.Add(curr.val);

                if (leftToRight)
                {
                    if (curr.left != null)
                    {
                        nextStack.Push(curr.left);
                    }

                    if (curr.right != null)
                    {
                        nextStack.Push(curr.right);
                    }
                }
                else
                {
                    if (curr.right != null)
                    {
                        nextStack.Push(curr.right);
                    }

                    if (curr.left != null)
                    {
                        nextStack.Push(curr.left);
                    }
                }

                if (currStack.Count == 0)
                {
                    list.Add(levelList);
                    levelList = new List<int>();
                    leftToRight = !leftToRight;
                    (currStack, nextStack) = (nextStack, currStack);
                }
            
            }
        }
        
        

        Zigzag();
        return list;
    }
}

//it is not mine
public partial class Solution
{
    private List<IList<int>> list = new();
    public void BFS(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool leftOrRight = true;

        while (queue.Count > 0)
        {
            List<int> curElement = new();
            var queueLength = queue.Count;

            for (int i = 0; i < queueLength; i++)
            {
                TreeNode currentNode = queue.Dequeue();

                if (leftOrRight)
                {
                    curElement.Add(currentNode.val);
                }
                else
                {
                    curElement.Insert(0,currentNode.val);
                }

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }

            leftOrRight = !leftOrRight;
            list.Add(curElement);
        }
    }
}