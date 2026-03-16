using Algorithms.Models;

// https://leetcode.com/problems/same-tree

namespace Algorithms.tbank_interview.Easy;

public static class SameTree_2Gen
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        return CheckNode(p, q);
    }

    private static bool CheckNode(TreeNode right, TreeNode left)
    {
        if (right is null && left is null)
            return true;

        if ((right is null && left is not null) || (left is null && right is not null))
            return false;

        if (right.val != left.val)
            return false;

        return CheckNode(right.right, left.right) && CheckNode(right.left, left.left);
    }
}