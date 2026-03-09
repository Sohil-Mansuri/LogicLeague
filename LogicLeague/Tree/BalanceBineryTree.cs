


namespace LogicLeague.Tree
{
    internal class BalanceBineryTree
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root is null) return true;

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            if(Math.Abs(leftHeight - rightHeight) > 1)
            {
                return false;
            }

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private static int GetHeight(TreeNode node)
        {
            if (node is null) return 0;

            int leftHeight = GetHeight(node.left);
            int rightHeight = GetHeight(node.right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
