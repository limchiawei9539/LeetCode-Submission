using System;

namespace _1448._Count_Good_Nodes_in_Binary_Tree
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

        static void Main(string[] args)
        {
            Console.WriteLine(GoodNodes(new TreeNode() { val = 2, right = new TreeNode() { val = 4, left = new TreeNode() { val = 10 }, right = new TreeNode() { val = 8, left = new TreeNode() { val = 4 } } } }));
        }

        public static int GoodNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + NodeRecursive(root.left, root.val) + NodeRecursive(root.right, root.val);
        }

        public static int NodeRecursive(TreeNode node, int max)
        {
            int result = 0;
            if (node == null)
            {
                return 0;
            }
            result = (node.val >= max) ? 1 : result;
            max = (node.val > max) ? node.val : max;
            result += NodeRecursive(node.left, max);
            result += NodeRecursive(node.right, max);
            return result;
        }
    }
}
