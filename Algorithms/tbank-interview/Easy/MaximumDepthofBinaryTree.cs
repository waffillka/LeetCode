using Algorithms.Models;

//https://leetcode.com/problems/maximum-depth-of-binary-tree

namespace Algorithms.tbank_interview.Easy;

public class MaximumDepthofBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        return Math.Max(MaxDepth(root.right), MaxDepth(root.left)) + 1;
    }
}