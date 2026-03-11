

namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/find-leaves-of-binary-tree/description/
    /// </summary>
    internal class FindLeavesOfBinaryTree
    {
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            if (root is null) return [];

            IList<IList<int>> result = [];
            while (root is not null)
            {
                var leaves = new List<int>();
                root = RemoveLeaves(root, leaves);
                result.Add(leaves);
            }

            return result;
        }

        private TreeNode RemoveLeaves(TreeNode node, List<int> leaves)
        {
            if (node is null) return null;

            if (node.left is null && node.right is null)
            {
                leaves.Add(node.val);
                return null;
            }

            node.left = RemoveLeaves(node.left, leaves);
            node.right = RemoveLeaves(node.right, leaves);
            return node;
        }

        public IList<IList<int>> FindLeavesV2(TreeNode root)
        {
            if (root is null) return [];

            IList<IList<int>> result = [];

            GetHeight(root, result);

            return result;
        }

        public int GetHeight(TreeNode node, IList<IList<int>> result)
        {
            if (node is null) return -1;

            int leftHeight = GetHeight(node.left, result);
            int rightHeight = GetHeight(node.right, result);

            var height = Math.Max(leftHeight, rightHeight) + 1;

            if (result.Count == height)
                result.Add(new List<int>());

            result[height].Add(node.val);

            return height;
        }
    }
}
