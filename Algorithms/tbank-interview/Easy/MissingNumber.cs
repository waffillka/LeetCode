namespace Algorithms.tbank_interview.Easy;
//https://leetcode.com/problems/missing-number/description/
public static class MissingNumber
{
    private static int MissingNumber_gen(int[] nums)
    {
        var maxSum = nums.Length * (nums.Length + 1) / 2;

        var sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        
        return maxSum - sum;
    }

    private static int MissingNumber_2gen(int[] nums)
    {
        var maxSum = nums.Length * (nums.Length + 1) / 2;

        var sum = nums.Sum();
        
        return maxSum - sum;
    }

    public static void Test()
    {
        var result = MissingNumber_gen([0, 1, 3]);
        Console.WriteLine(result);
    }
}