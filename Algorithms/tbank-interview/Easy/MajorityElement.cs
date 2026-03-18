namespace Algorithms.tbank_interview.Easy;

// https://leetcode.com/problems/majority-element/
public static class MajorityElement
{
    private static int MajorityElement_gen(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }

        return dict.MaxBy(x => x.Value).Key;
    }

    public static void Test()
    {
        var result = MajorityElement_gen([]);
        Console.WriteLine(result);
    }
}