using Algorithms.Models;

namespace Algorithms.tbank_interview.Easy;

public static class InvertBinaryTree
{
    private static TreeNode InvertTree(TreeNode root)
    {
        InvertList(root);
        return root;
    }

    private static void InvertList(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        (root.left, root.right) = (root.right, root.left);

        InvertList(root.left);
        InvertList(root.right);
    }

    public static void Test()
    {
        var result = InvertTree(new TreeNode());
        Console.WriteLine(result);
    }
}