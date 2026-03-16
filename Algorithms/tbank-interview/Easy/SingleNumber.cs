namespace Algorithms.tbank_interview.Easy;

public static class SingleNumber
{
    private static int SingleNumber_GEN(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var t in nums)
        {
            if (!dict.TryAdd(t, 1))
            {
                dict[t]++;
            }
        }

        return dict.MinBy(x => x.Value).Key;
    }

    private static int SingleNumber_2GEN(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }

        return result;
    }

    public static void Test()
    {
        var result = SingleNumber_GEN([2, 2, 1]);
        Console.WriteLine(result);
    }
}