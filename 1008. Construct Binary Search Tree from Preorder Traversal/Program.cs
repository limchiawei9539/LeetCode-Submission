using System;
using System.Diagnostics;

namespace _1008._Construct_Binary_Search_Tree_from_Preorder_Traversal
{
    class Program
    {
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

        static int idx = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(BstFromPreorder(new int[6] { 8, 5, 1, 7, 10, 12 }));
            Console.WriteLine(BstFromPreorder(new int[2] { 1, 3 }));
        }

        public static TreeNode BstFromPreorder(int[] preorder)
        {
            var root = new TreeNode();
            root.val = preorder[0];
            while (idx < preorder.Length)
            {
                BuildTreeNode(root, preorder[idx]);
                idx++;
            }
            return root;
        }

        public static void BuildTreeNode(TreeNode root, int key)
        {
            if (key > root.val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(key);
                }
                else
                {
                    BuildTreeNode(root.right, key);
                }
            }
            else if (key < root.val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(key);
                }
                else
                {
                    BuildTreeNode(root.left, key);
                }
            }
        }
    }
}
