namespace Algorithms.tbank_interview.Medium;

public static class SubarraySumEqualsK
{
    public static int SubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int, int> { { 0, 1 } };
        var sum = 0;

        var result = 0;

        foreach (var item in nums)
        {
            sum += item;
            var diff = sum - k;


            if (dict.TryGetValue(diff, out var value))
            {
                result += value;
            } 
            
            dict.TryAdd(sum, 0);
            
            dict[sum]++;
        }

        return result;
    }
}