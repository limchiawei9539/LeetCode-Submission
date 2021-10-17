using System;
using System.Collections.Generic;

namespace _437._Path_Sum_III
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
            Console.WriteLine("Hello World!");
        }

        public static int PathSum(TreeNode root, int targetSum)
        {
            var count = GetCount(root, targetSum, 0, new List<int>());
            return count;
        }

        public static int GetCount(TreeNode root, int targetSum, int count, List<int> list)
        {
            if(root!=null)
            {
                list.Add(root.val);
                var sum = 0;
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    sum += list[i];
                    count = (sum == targetSum) ? count + 1 : count;
                }

                var originalLength = list.Count;
                if (root.left != null)
                {
                    count = GetCount(root.left, targetSum, count, list);
                }

                if (root.right != null)
                {
                    list.RemoveRange(originalLength - 1, list.Count - originalLength);
                    count = GetCount(root.right, targetSum, count, list);
                }
            }
            return count;
        }
    }
}
