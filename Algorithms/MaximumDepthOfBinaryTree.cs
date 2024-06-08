using Algorithms.Models;

namespace Algorithms;

public static class MaximumDepthOfBinaryTree
{
    public static int MaxDepth1(TreeNode root)
    {
        return CalculateMaxDepthOfTree(root, 0);
    } 
    
    public static int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        
        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;
    }

    private static int CalculateMaxDepthOfTree(TreeNode node, int count)
    {
        if (node == null)
        {
            return count;
        }

        count++;
        var left = CalculateMaxDepthOfTree(node.left, count);
        var right = CalculateMaxDepthOfTree(node.right, count);
        return right >= left ? right : left;
    }
}