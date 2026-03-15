namespace Algorithms.tbank.Medium;

public static class TwoSum
{
    public static int[] TwoSum1(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        while (low < high) {
            int sum = nums[low] + nums[high];
                          
            if (sum == target) {
                return [low + 1, high + 1];
            } else if (sum < target) {
                ++low;
            } else {
                --high;
            }
        }
        
        return [-1, -1];
    }
    
    public static void Test()
    {
        var result = TwoSum1([2, 5, 5, 11], 10);
        Console.WriteLine(result);
    }
}