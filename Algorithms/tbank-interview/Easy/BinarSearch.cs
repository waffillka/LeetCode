namespace Algorithms.tbank_interview.Easy;

public static class BinarSearch
{
    private static int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }

    public static void Test()
    {
        var result = Search([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 7);
        Console.WriteLine(result);
    }
}