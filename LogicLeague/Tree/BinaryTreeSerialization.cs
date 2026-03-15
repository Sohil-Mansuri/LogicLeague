

using System.Text;

namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
    /// https://leetcode.com/problems/serialize-and-deserialize-bst/description/
    /// </summary>
    internal class BinaryTreeSerialization
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return null;

            StringBuilder output = new();

            PreOrder(root, output);

            return output.ToString();
        }

        private void PreOrder(TreeNode node, StringBuilder output)
        {
            if (node is null)
            {
                output.Append("N,");
                return;
            }

            output.Append(node.val).Append(',');

            PreOrder(node.left, output);
            PreOrder(node.right, output);
        }

        // Decodes your encoded data to tree.
        int index = 0;
        public TreeNode deserialize(string data)
        {
            if (data is null) return null;

            var strings = data.Split(',', StringSplitOptions.RemoveEmptyEntries);

            return GenerateTree(strings);
        }

        private TreeNode GenerateTree(string[] strings)
        {
            if (strings.Length == index) return null;

            if (strings[index] == "N")
            {
                index++;
                return null;
            }

            var node = new TreeNode(Convert.ToInt32(strings[index]));
            index++;

            node.left = GenerateTree(strings);
            node.right = GenerateTree(strings);

            return node;
        }

    }
}
