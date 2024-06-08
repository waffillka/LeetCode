using Algorithms.Models;

namespace Algorithms;

public static class SymmetricTree
{
    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return IsMirror(root.left, root.right);
    }

    private static bool IsMirror(TreeNode leftNode, TreeNode rightNode)
    {
        if (leftNode == null && rightNode == null)
        {
            return true;
        }

        if (leftNode == null || rightNode == null || leftNode.val != rightNode.val)
        {
            return false;
        }

        return IsMirror(leftNode.left, rightNode.right) && IsMirror(leftNode.right, rightNode.left);
    }
}