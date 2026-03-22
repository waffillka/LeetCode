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
        var result = MajorityElement_gen([1, 2, 4, 3, 3, 3, 5, 5, 6, 6, 2, 4, 5, 2]);
        Console.WriteLine(result);
    }
}