namespace Algorithms;

public static class BinaryTreeInorderTraversal
{
    public static IList<int> InorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        InorderHelper(root, result);
        return result;
    }

    private static void InorderHelper(TreeNode node, List<int> result)
    {
        if (node == null)
        {
            return;
        }
        
        InorderHelper(node.left, result);
        result.Add(node.val);
        InorderHelper(node.right, result);
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}