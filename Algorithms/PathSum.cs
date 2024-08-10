using Algorithms.Models;

namespace Algorithms;

public class PathSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        targetSum -= root.val;

        if (targetSum == 0 && root.left == null && root.right == null)
        {
            return true;
        }

        return (root.left != null ? HasPathSum(root.left, targetSum) : false)
               || (root.right != null ? HasPathSum(root.right, targetSum) : false);
    }
}