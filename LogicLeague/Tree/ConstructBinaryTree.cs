
namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    /// </summary>
    internal class ConstructBinaryTree
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> map = [];

            for (int i = 0; i < inorder.Length; i++)
            {
                map[inorder[i]] = i;
            }

            int preIndex = 0;

            return BuildTree(preorder, 0, inorder.Length - 1, map, ref preIndex);
        }

        private TreeNode BuildTree(int[] preorder, int left, int right, Dictionary<int, int> map, ref int preIndex)
        {
            if (left > right) return null;

            var rootValue = preorder[preIndex++];
            var root = new TreeNode { val = rootValue };

            int mid = map[rootValue];

            root.left = BuildTree(preorder, left, mid - 1, map, ref preIndex);
            root.right = BuildTree(preorder, mid + 1, right, map, ref preIndex);

            return root;
        }
    }
}
