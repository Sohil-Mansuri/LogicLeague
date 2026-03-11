namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-right-side-view/description/
    /// </summary>
    internal class BinaryRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root is null) return [];
            Queue<TreeNode> queue = new();

            IList<int> result = [];

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var length = queue.Count;

                //result.Add(queue.Last().val);

                for (int i = 0; i < length; i++)
                {
                    var node = queue.Dequeue();

                    if (i == length - 1)
                        result.Add(node.val);

                    if (node.left is not null)
                        queue.Enqueue(node.left);

                    if (node.right is not null)
                        queue.Enqueue(node.right);
                }
            }

            return result;
        }
    }
}
