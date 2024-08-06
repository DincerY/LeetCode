﻿using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

Solution solution = new();
solution.Flatten(new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)),
    new TreeNode(5, null, new TreeNode(6))));

// solution.Flatten(new TreeNode(1,null,new TreeNode(2)));
//solution.Flatten(new TreeNode(1,null,new TreeNode(2,new TreeNode(3))));

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

public class Solution
{
    public void Flatten(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            return;
        }
        var left = Dfs(root.left);
        var right = Dfs(root.right);
        
        root.right = left;
        root.left = null;
        while (left.right != null)
        {
            left = left.right;
        }

        left.right = right;


    }

    private TreeNode Dfs(TreeNode node)
    {
        if (node == null)
        {
            return null;
        }
        Console.WriteLine(node.val);
        var leftNode = Dfs(node.left);

        if (node.left != null && node.right != null)
        {
            node.left = null;
            var tempRight = node.right;
            node.right = leftNode;
            while (leftNode != null && leftNode.right != null)
            {
                leftNode = leftNode.right;
            }
            leftNode.right = tempRight;
        }

        return node;
    }
}