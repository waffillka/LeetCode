namespace Algorithms.tbank_interview.Medium;

// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
public static class FindFirstandLastPositionofElementinSortedArray
{
    private static int[] SearchRange(int[] nums, int target)
    {
        return [SearchRange_3Gen(nums, target, true), SearchRange_3Gen(nums, target)];
    }

    private static int BinarySearch(int[] nums, int target, bool findFirst = false)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = -1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                if (findFirst)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }

    public static int[] SearchRange_2Gen(int[] nums, int target)
    {
        int first = -1, last = -1;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                if (first == -1) first = i; // Found the first occurrence
                last = i; // Keep updating last until the end of the target block
            }
        }

        return [first, last];
    }

    private static int SearchRange_3Gen(int[] nums, int target, bool first = false)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = -1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;


                if (first)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }

    public static void Test()
    {
        var result = SearchRange([1, 2, 3, 4, 5, 6, 7, 7, 7, 7], 7);
        Console.WriteLine(result);
    }
}