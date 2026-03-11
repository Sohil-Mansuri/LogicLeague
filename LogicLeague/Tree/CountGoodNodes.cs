namespace LogicLeague.Tree
{
    internal class CountGoodNodes
    {
        public int GoodNodes(TreeNode root)
        {
            if (root is null) return 0;

            int max = root.val;
            int count = 0;

            DFS(root, max, ref count);

            return count;
        }

        private void DFS(TreeNode node, int max, ref int count)
        {
            if (node == null) return;

            if (node.val >= max)
            {
                count++;
                max = node.val;
            }

            if (node.left != null)
            {
                DFS(node.left, max, ref count);
            }

            if (node.right != null)
            {
                DFS(node.right, max, ref count);
            }
        }
    }
}
