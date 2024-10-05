namespace Algorithms.tbank.Easy;

public static class MoveZeroesType
{
    public static void MoveZeroes(int[] nums)
    {
        if (nums.Length <= 1) return;
        var temp = 0;
        var zeroCounts = 0;
        for (var i = 0; i < nums.Length - zeroCounts; i++)
        {
            if (nums[i] == 0)
            {
                for (var j = i; j < nums.Length - 1 - zeroCounts; j++)
                {
                    temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }

                zeroCounts++;

                if (nums[i] == 0)
                {
                    i--;
                }
            }
        }
    }

    public static void MoveZeroesV2(int[] nums)
    {
        var NonZeroIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[NonZeroIndex] = nums[i];
                NonZeroIndex++;
            }
        }

        if (NonZeroIndex == nums.Length) return;
        for (var i = NonZeroIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}