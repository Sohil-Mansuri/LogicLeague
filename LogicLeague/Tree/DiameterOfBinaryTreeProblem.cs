namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/diameter-of-binary-tree/description/
    /// </summary>
    internal class DiameterOfBinaryTreeProblem
    {
        private static int _diameter = 0;

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root is null) return _diameter;
            FindLength(root);

            return _diameter;
        }

        private static int FindLength(TreeNode node)
        {
            if (node is null) return 0;

            int leftHeight = FindLength(node.left);
            int rightHeight = FindLength(node.right);

            _diameter = Math.Max(_diameter, leftHeight + rightHeight);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
