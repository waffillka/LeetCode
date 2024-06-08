using Algorithms.Models;

namespace Algorithms;

public static class BalancedBinaryTree
{
    public static bool IsBalanced(TreeNode root)
    {
        bool isBalanced = true;
        Height(root, ref isBalanced);
        return isBalanced;
    }

    private static int Height(TreeNode root, ref bool isBalanced)
    {
        if (root == null)
            return -1;
        int left = Height(root.left, ref isBalanced);
        int right = Height(root.right, ref isBalanced);
        int max = left;
        int dif = left - right;
        if (right > left)
        {
            max = right;
            dif = right - left;
        }

        if (dif > 1)
        {
            isBalanced = false;
            return 0;
        }

        return 1 + max;
    }

    public static bool IsBalanced1(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return Math.Abs(MaxDepth(root.right) - MaxDepth(root.left)) <= 1
               && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private static int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;
    }
}