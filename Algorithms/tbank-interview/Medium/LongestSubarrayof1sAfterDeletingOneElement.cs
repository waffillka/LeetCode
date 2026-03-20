namespace Algorithms.tbank_interview.Medium;

public static class LongestSubarrayof1SAfterDeletingOneElement
{
    private static int LongestSubarray(int[] nums)
    {
        var deleted = false;
        var lastNullIndex = -1;
        var index = 0;
        var result = 0;
        var count = 0;

        while (index < nums.Length)
        {
            if (nums[index] == 0)
            {
                if (deleted)
                {
                    result = Math.Max(result, count);
                    count = 0;
                    deleted = false;
                    index = lastNullIndex;
                }
                else
                {
                    count++;
                    deleted = true;
                    lastNullIndex = index;
                }
            }
            else
            {
                count++;
            }

            index++;
        }

        return Math.Max(result, count) - 1;
    }

    private static int LongestSubarray_gen(int[] nums)
    {
        var sizes = new List<int>();
        var count = 0;
        foreach (var t in nums)
        {
            if (t == 0)
            {
                sizes.Add(count);
                count = 0;
            }
            else
            {
                count++;
            }
        }

        sizes.Add(count);

        switch (sizes.Count)
        {
            case 1:
                return sizes[0] - 1;
            case 0:
                return 0;
        }

        var result = 0;
        for (var i = 0; i < sizes.Count - 1; i++)
        {
            result = Math.Max(result, sizes[i] + sizes[i + 1]);
        }

        return result;
    }

    public static void Test()
    {
        //var result = LongestSubarray_gen([0, 1, 1, 1, 0, 1, 1, 0, 1]);
        var result = LongestSubarray_gen([1, 1, 0, 1]);
        Console.WriteLine(result);
    }
}