using System.ComponentModel.Design.Serialization;
using Algorithms.Models;

namespace Algorithms.tbank_interview.Easy;

public class PathSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        if (root.right is null && root.left is null && (targetSum - root.val) == 0)
        {
            return true;
        }

        return HasPathSum(root.right, targetSum - root.val) || HasPathSum(root.left, targetSum - root.val);
    }
}