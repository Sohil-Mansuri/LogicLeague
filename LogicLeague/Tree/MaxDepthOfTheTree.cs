
namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    internal class MaxDepthOfTheTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root is null) return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;

        }
    }
}
