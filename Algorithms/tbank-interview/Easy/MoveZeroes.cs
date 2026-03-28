namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/move-zeroes/description/
public static class MoveZeroes
{
    private static int[] MoveZeroes_gen(int[] nums)
    {
        var countZero = 0;
        for (var i = 0; i < nums.Length - countZero; i++)
        {
            if (nums[i] == 0)
            {
                for (var j = i; j < nums.Length - countZero - 1; j++)
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }

                countZero++;
                i--;
            }
        }

        return nums;
    }

    private static int[] MoveZeroes_2gen(int[] nums)
    {
        var zero = 0;
        var i = 0;

        while (i < nums.Length)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[zero]) = (nums[zero], nums[i]);
                zero++;
            }

            i++;
        }

        return nums;
    }

    public static void Test()
    {
        var result = MoveZeroes_2gen([0, 1, 0, 3, 12]);
        //var result = MoveZeroes_gen([0, 0, 1]);
        Console.WriteLine(result);
    }
}