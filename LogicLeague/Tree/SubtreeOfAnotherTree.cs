
namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/subtree-of-another-tree/description/
    /// </summary>
    internal class SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root is null) return false;

            if (IsSame(root, subRoot)) return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private bool IsSame(TreeNode root, TreeNode subRoot)
        {
            if (root is null && subRoot is null) return true;

            if (root is null || subRoot is null) return false;

            if (root.val != subRoot.val) return false;

            return IsSame(root.left, subRoot.left) && IsSame(root.right, subRoot.right);
        }
    }
}
