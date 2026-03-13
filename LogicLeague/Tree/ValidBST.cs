
namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-search-tree/description/
    /// </summary>
    internal class ValidBST
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root is null) return true;

            int? previous = null;

            return Inorder(root, ref previous);
        }

        private bool Inorder(TreeNode node, ref int? previous)
        {
            if (node is null) return true;

            if (!Inorder(node.left, ref previous)) return false;

            if (previous is not null && previous >= node.val)
            {
                return false;
            }

            previous = node.val;

            return Inorder(node.right, ref previous);
        }
    }
}
