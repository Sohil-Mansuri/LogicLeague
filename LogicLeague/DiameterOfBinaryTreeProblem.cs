
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/diameter-of-binary-tree/description/
    /// </summary>
    internal class DiameterOfBinaryTreeProblem
    {
        private static int _diameter = 0;

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return _diameter;

            FindLength(root);

            return _diameter;

        }

        private static int FindLength(TreeNode node)
        {
            if (node == null) return 0;

            int leftHeight = FindLength(node.left);
            int rightHeight = FindLength(node.right);

            _diameter = Math.Max(_diameter, leftHeight + rightHeight);

            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }

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

}
