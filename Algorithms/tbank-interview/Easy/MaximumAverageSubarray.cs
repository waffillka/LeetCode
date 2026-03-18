namespace Algorithms.tbank_interview.Easy;

public static class MaximumAverageSubarray
{
    private static double FindMaxAverage(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var maxSum = 0;

        for (var i = 0; i < k; i++)
        {
            maxSum += nums[i];
        }

        var tempSum = maxSum;

        for (var i = k; i < nums.Length; i++)
        {
            tempSum = tempSum - nums[i - k] + nums[i];
            maxSum = Math.Max(maxSum, tempSum);
        }

        return (double)maxSum / k;
    }

    public static void Test()
    {
        var result = FindMaxAverage([0, 4, 0, 3, 2], 1);
        Console.WriteLine(result);
    }
}