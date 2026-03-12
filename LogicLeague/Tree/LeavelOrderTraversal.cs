

namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    internal class LeavelOrderTraversal
    {
        // Using BFS
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = [];

            if (root is null) return result;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var length = queue.Count;

                var currentLevel = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    var node = queue.Dequeue();
                    currentLevel.Add(node.val);

                    if (node.left is not null) queue.Enqueue(node.left);

                    if (node.right is not null) queue.Enqueue(node.right);
                }

                result.Add(currentLevel);
            }

            return result;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root is null) return [];

            IList<IList<int>> result = [];

            DFS(root, 0, result);

            return result;
        }

        private void DFS(TreeNode node, int level, IList<IList<int>> result)
        {
            if (node is null) return;

            if (result.Count == level) result.Add(new List<int>());

            result[level].Add(node.val);

            DFS(node.left, level + 1, result);
            DFS(node.right, level + 1, result);
        }
    }
}
