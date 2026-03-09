namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree
    /// </summary>
    internal class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root is null) return true;
            return IsSymmetric(root.left, root.right);
        }

        public bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            return left.val == right.val &&
            IsSymmetric(left.left, right.right) &&
            IsSymmetric(left.right, right.left);
        }
    }
}
