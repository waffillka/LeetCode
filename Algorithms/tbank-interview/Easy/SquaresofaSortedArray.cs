namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/squares-of-a-sorted-array/
public static class SquaresofaSortedArray
{
    private static int[] SortedSquares(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = new List<int>(nums.Length);
        while (left <= right)
        {
            var leftSq = nums[left] * nums[left];
            var rightSq = nums[right] * nums[right];

            if (leftSq < rightSq)
            {
                result.Add(rightSq);
                right--;
            }
            else
            {
                result.Add(leftSq);
                left++;
            }
        }

        result.Reverse();
        return result.ToArray();
    }

    private static int[] SortedSquares_2Gen(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = new int[nums.Length];
        var index = nums.Length - 1;
        while (left <= right)
        {
            var leftSq = nums[left] * nums[left];
            var rightSq = nums[right] * nums[right];

            if (leftSq < rightSq)
            {
                result[index] = rightSq;
                right--;
            }
            else
            {
                result[index] = leftSq;
                left++;
            }

            index--;
        }
        
        return result;
    }

    public static void Test()
    {
        var result = SortedSquares([-4, -1, 0, 3, 10]);
        Console.WriteLine(result);
    }
}