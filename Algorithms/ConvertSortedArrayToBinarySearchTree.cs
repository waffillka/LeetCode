using Algorithms.Models;

namespace Algorithms;

public static class ConvertSortedArrayToBinarySearchTree
{
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        return BuildTree(nums, 0, nums.Length - 1);
    }

    private static TreeNode BuildTree(int[] nums, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int mid = (end + start) / 2;
        var root = new TreeNode(nums[mid]);
        root.left = BuildTree(nums, start, mid - 1);
        root.right = BuildTree(nums, mid + 1, end);
        return root;
    }
}