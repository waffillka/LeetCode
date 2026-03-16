using Algorithms.Models;
// https://leetcode.com/problems/minimum-depth-of-binary-tree/
namespace Algorithms.tbank_interview.Easy;

public static class MinimumDepthofBinaryTree
{
    public static int MinDepth(TreeNode root)
    {
        if (root is null)
            return 0;

        return MinDepthCalc(root);
    }

    private static int MinDepthCalc(TreeNode root)
    {
        if (root is null)
            return 0;

        if (root.left is null && root.right is null)
        {
            return 1;
        }

        if (root.left is null)
        {
            return MinDepthCalc(root.right) + 1;
        }

        if (root.right is null)
        {
            return MinDepthCalc(root.left) + 1;
        }
        
        return Math.Min(MinDepthCalc(root.left), MinDepthCalc(root.right)) + 1;
    }
}