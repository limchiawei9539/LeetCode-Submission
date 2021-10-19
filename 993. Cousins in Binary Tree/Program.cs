using System;
using System.Collections.Generic;

namespace _993._Cousins_in_Binary_Tree
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

        public static int parentX = -1;
        public static int parentY = -1;
        public static int depthX = -1;
        public static int depthY = -1;

        static void Main(string[] args)
        {
            Console.WriteLine(IsCousins(new TreeNode() { val = 1, left = new TreeNode() { val = 2, left = new TreeNode() { val = 4 } }, right = new TreeNode() { val = 3, left = new TreeNode() { val = 5 } } }, 4, 5));
        }

        public static bool IsCousins(TreeNode root, int x, int y)
        {
            GetDepth(root, x, y, root.val, 0);
            return parentX != parentY && depthX == depthY;
        }

        public static void GetDepth(TreeNode root, int x, int y, int parent, int depth)
        {
            if(parentX != -1 && parentY != -1)
            {
                return;
            }

            if (root == null)
            {
                return;
            }
            if (root.val == x)
            {
                parentX = parent;
                depthX = depth;
            }
            else if (root.val == y)
            {
                parentY = parent;
                depthY = depth;
            }
            else
            {
                GetDepth(root.left, x, y, root.val, depth + 1);
                GetDepth(root.right, x, y, root.val, depth + 1);
            }
        }

    }
}
