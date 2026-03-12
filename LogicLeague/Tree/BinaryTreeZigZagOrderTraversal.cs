namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/
    /// </summary>
    internal class BinaryTreeZigZagOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root is null) return [];
            IList<IList<int>> result = [];
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            bool isLeftToRight = true;
            while (queue.Count > 0)
            {
                var length = queue.Count;

                LinkedList<int> level = new();
                for (int i = 0; i < length; i++)
                {
                    var node = queue.Dequeue();

                    if (isLeftToRight)
                        level.AddLast(node.val);
                    else
                        level.AddFirst(node.val);

                    if (node.left is not null) queue.Enqueue(node.left);
                    if (node.right is not null) queue.Enqueue(node.right);
                }

                result.Add(level.ToList());
                isLeftToRight = !isLeftToRight;
            }


            return result;
        }
    }
}
