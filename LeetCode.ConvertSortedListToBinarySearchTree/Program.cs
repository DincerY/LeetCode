Solution solution = new();
//solution.SortedListToBST2(new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9))))));
solution.SortedListToBST2(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5,new ListNode(6)))))));


Console.WriteLine("Hello, World!");


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
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
    public TreeNode SortedListToBST(ListNode head)
    {
        List<int> list = new();

        void Recursi(ListNode head)
        {
            if (head == null)
            {
                return;
            }
            list.Add(head.val);
            Recursi(head.next);
        }
        Recursi(head);

        var nums = list.ToArray();
        if (nums.Length < 1)
        {
            return null;
        }
        TreeNode Recursive(int l, int r)
        {
            int mid = (r + l) / 2;
            if (l > r)
            {
                return null;
            }
            TreeNode root = new(nums[mid]);

            root.left = Recursive(l,mid - 1);
            root.right = Recursive(mid + 1,r);

            return root;
        }

        return Recursive(0,nums.Length-1);
        
    }
}

public partial class Solution {
    public TreeNode SortedListToBST2(ListNode head) {
        int n = 0;
        ListNode cur = head;
        while (cur != null) {
            cur = cur.next;
            n++;
        }

        return Rec(0, n - 1);
        
        TreeNode Rec(int st, int end) {
            if (st > end) return null;

            int mid = (st + end) / 2;
            TreeNode left = Rec(st, mid - 1);

            TreeNode root = new TreeNode(head.val);
            head = head.next;
            root.left = left;

            root.right = Rec(mid + 1, end);
            return root;
        }
    }

}
