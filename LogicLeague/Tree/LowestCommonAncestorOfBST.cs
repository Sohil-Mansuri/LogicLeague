namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    /// </summary>
    internal class LowestCommonAncestorOfBST
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root is null) return null;

            if (p.val > root.val && q.val > root.val) return LowestCommonAncestor(root.right, p, q);

            if (p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);

            return root;
        }
    }
}
