namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/description/
    /// </summary>
    internal class FlatternBineryTree
    {
        public static void Flatten(TreeNode root)
        {
            FlattenBacktrack(root);
        }


        private static TreeNode FlattenBacktrack(TreeNode node)
        {
            if (node == null) return null;

            if (node.left is null && node.right is null) return node;

            var left = FlattenBacktrack(node.left);
            var right = FlattenBacktrack(node.right);

            if (left != null)
            {
                left.right = node.right;
                node.right = node.left;
                node.left = null;
            }

            return right == null ? left : right;
        }
    }
}
