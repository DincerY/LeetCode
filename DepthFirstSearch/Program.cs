using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace DepthFirstSearch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Node CreteRoot(int value)
            {
                return new Node(value);
            }
        
            Node Insert(Node node,int value)
            {
                if (node == null)
                {
                    return CreteRoot(value);
                }

                if (value < node.Data)
                {
                    node.Left = Insert(node.Left, value);
                }
                if (value > node.Data)
                {
                    node.Right = Insert(node.Right, value);
                }

                return node;
            }
            //DepthFirstSearch
            void Traverse(Node node)
            {
                if (node != null)
                {
                    Traverse(node.Left);
                    Console.WriteLine($"{node.Data}");
                    Traverse(node.Right);
                }
            }

            
            
            Node root = null;
            
            root = Insert(root, 50);
            Insert(root, 30);
            Insert(root, 20);
            Insert(root, 40);
            Insert(root, 70);
            Insert(root, 60);
            Insert(root, 80);
            
            
            Traverse(root);
            
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
              
    }
}