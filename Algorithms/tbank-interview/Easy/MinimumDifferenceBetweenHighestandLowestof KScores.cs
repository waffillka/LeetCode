namespace Algorithms.tbank_interview.Easy;

public static class MinimumDifferenceBetweenHighestandLowestofKScores
{
    private static int MinimumDifference(int[] nums, int k)
    {
        if (k == 1)
            return 0;

        Array.Sort(nums);
        var result = int.MaxValue;
        for (var i = 0; i < nums.Length - k + 1 ; i++)
        {
            var temp = nums[i + k - 1] - nums[i];
            result = Math.Min(result, temp);
        }

        return result;
    }

    public static void Test()
    {
        var result = MinimumDifference([1, 3, 5, 6], 2);
        Console.WriteLine(result);
    }
}