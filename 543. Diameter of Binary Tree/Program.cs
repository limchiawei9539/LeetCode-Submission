using System;

namespace _543._Diameter_of_Binary_Tree
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

        static int result = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(GoodNodes(new TreeNode() { val = 1, left = new TreeNode() { val = 2 } }));
            Console.WriteLine(GoodNodes(new TreeNode() { val = 1, left = new TreeNode() { val = 2, left = new TreeNode() { val = 4 }, right = new TreeNode() { val = 5 } }, right = new TreeNode() { val = 3 } }));
        }

        public static int GoodNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            NodeRecursive(root);
            return result;
        }

        public static int NodeRecursive(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            var left = NodeRecursive(node.left);
            var right = NodeRecursive(node.right);
            int curr = left + right;
            result = Math.Max(curr,result);
            return Math.Max(left,right)+1;
        }
    }
}
