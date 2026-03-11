namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/invert-binary-tree/description/
    /// </summary>
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root is null) return root;

           var left = InvertTree(root.left);
            var right = InvertTree(root.right);

            root.left = left;
            root.right = right;

            return root;
        }
    }
}
