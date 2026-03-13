
namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    /// </summary>
    internal class ConstructBinaryTreeV2
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            Dictionary<int, int> map = [];

            for (int i = 0; i < inorder.Length; i++)
            {
                map[inorder[i]] = i;
            }

            int postIndex = postorder.Length - 1;

            return BuildTree(postorder, 0, inorder.Length - 1, ref postIndex, map);
        }

        private TreeNode BuildTree(int[] postorder, int left, int right, ref int postIndex, Dictionary<int, int> map)
        {
            if (left > right) return null;

            var rootValue = postorder[postIndex--];
            var root = new TreeNode { val = rootValue };

            int mid = map[rootValue];

            root.right = BuildTree(postorder, mid + 1, right, ref postIndex, map);
            root.left = BuildTree(postorder, left, mid - 1, ref postIndex, map);

            return root;
        }
    }
}
