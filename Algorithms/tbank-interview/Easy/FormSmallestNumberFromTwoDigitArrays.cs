namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/form-smallest-number-from-two-digit-arrays/description/
public static class FormSmallestNumberFromTwoDigitArrays
{
    private static int MinNumber(int[] nums1, int[] nums2)
    {
        var commonDigits = nums1.Intersect(nums2).ToList();
        if (commonDigits.Count > 0)
        {
            return commonDigits.Min();
        }

        var min1 = nums1.Min();
        var min2 = nums2.Min();

        if (min1 == min2)
        {
            return min1;
        }

        if (min1 > min2)
        {
            return min2 * 10 + min1;
        }

        return min1 * 10 + min2;
    }

    private static int MinNumber_gen(int[] nums1, int[] nums2)
    {
        var numsCount1 = new int[10];
        var numsCount2 = new int[10];

        foreach (var item in nums2)
        {
            numsCount2[item]++;
        }

        foreach (var item in nums1)
        {
            numsCount1[item]++;
        }

        var min1 = nums1[0];
        var min2 = nums2[0];

        for (var i = 0; i < 10; i++)
        {
            if (numsCount1[i] > 0 && numsCount2[i] > 0)
            {
                return i;
            }

            if (numsCount1[i] > 0)
            {
                min1 = Math.Min(min1, i);
            }

            if (numsCount2[i] > 0)
            {
                min2 = Math.Min(min2, i);
            }
        }

        return min1 > min2 ? min2 * 10 + min1 : min1 * 10 + min2;
    }

    public static void Test()
    {
        var result = MinNumber_gen([3, 5, 2, 6], [3, 1, 7]);
        Console.WriteLine(result);

        result = MinNumber_gen([4, 1, 3], [5, 7]);
        Console.WriteLine(result);
    }
}