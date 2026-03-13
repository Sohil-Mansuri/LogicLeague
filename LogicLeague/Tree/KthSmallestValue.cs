
namespace LogicLeague.Tree
{
    internal class KthSmallestValue
    {
        public int KthSmallest(TreeNode root, int k)
        {
            if (root is null) return -1;

            List<int> result = [];

            DFS(root, result);

            return result[k - 1];
        }

        private void DFS(TreeNode node, List<int> result)
        {
            if (node.left is null && node.right is null)
            {
                result.Add(node.val);
                return;
            }

            if (node.left is not null) DFS(node.left, result);

            result.Add(node.val);

            if (node.right is not null) DFS(node.right, result);

        }
    }
}
