using System;
using System.Collections.Generic;
using System.Linq;

namespace _653._Two_Sum_IV___Input_is_a_BST
{
    class Program
    {
        public static HashSet<int> set = new HashSet<int>();
        static void Main(string[] args)
        {
            Console.WriteLine(FindTarget(new TreeNode() { val = 2, right = new TreeNode() { val = 4, left = new TreeNode() { val = 10 }, right = new TreeNode() { val = 8, left = new TreeNode() { val = 6 } } } }, 6));
        }

        public static bool FindTarget(TreeNode root, int k)
        {
            return NodeRecursive(root,k);
        }

        public static bool NodeRecursive(TreeNode node, int k)
        {
            if (node == null)
            {
                return false;
            }
            if (set.Contains(k - node.val))
            {
                return true;
            }
            set.Add(node.val);
            return NodeRecursive(node.left,k) || NodeRecursive(node.right,k);
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
    }
}
