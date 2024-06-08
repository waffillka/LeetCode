using Algorithms.Models;

namespace Algorithms;

public static class SameTree
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        return CheckRightNode(p, q);
    }

    private static bool CheckRightNode(TreeNode p, TreeNode q)
    {
        if(p == null && q == null)
        {
            return true;
        }

        if ((p == null && q != null) || (p != null && q == null))
        {
            return false;
        }

        if(p.val != q.val)
        {
            return false;
        }

        return CheckRightNode(p.left, q.left) && CheckRightNode(p.right, q.right); 
    }
}
