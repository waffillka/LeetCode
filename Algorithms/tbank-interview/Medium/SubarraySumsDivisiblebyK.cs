namespace Algorithms.tbank_interview.Medium;

public static class SubarraySumsDivisiblebyK
{
    private static int SubarraysDivByK(int[] nums, int k)
    {
        var dict = new Dictionary<int, int> { { 0, 1 } };
        var sum = 0;

        var result = 0;

        foreach (var item in nums)
        {
            sum += item;
            var n = sum % k;
            if (n < 0)
            {
                n += k;
            }

            if (!dict.TryAdd(n, 1))
            {
                result += dict[n];
                dict[n]++;
            }
        }

        return result;

    }
    
    public static void Test()
    {
        //[4,5,0,-2,-3,1], k = 5
        var result1 = SubarraysDivByK([-4, -5, 0, -2, -3, -1], 5);
        Console.WriteLine(result1);
        
        var result = SubarraysDivByK([4, 5, 0, -2, -3, 1], 5);
        Console.WriteLine(result);
    }
}