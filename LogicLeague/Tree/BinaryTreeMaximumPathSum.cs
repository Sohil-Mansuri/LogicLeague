namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-maximum-path-sum/
    /// </summary>
    internal class BinaryTreeMaximumPathSum
    {
        public int MaxPathSum(TreeNode root)
        {
            if (root is null) return -1;

            int maxSum = int.MinValue;

            DFS(root, ref maxSum);

            return maxSum;
        }

        public int DFS(TreeNode node, ref int maxSum)
        {
            if (node is null) return 0;
            int left = Math.Max(0, DFS(node.left, ref maxSum));
            int right = Math.Max(0, DFS(node.right, ref maxSum));
            maxSum = Math.Max(maxSum, left + right + node.val);
            return Math.Max(node.val + left, node.val + right);
        }
    }
}
