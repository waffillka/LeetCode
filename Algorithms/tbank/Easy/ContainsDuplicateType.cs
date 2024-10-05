namespace Algorithms.tbank.Easy;

public static class ContainsDuplicateType
{
    public static bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (!dict.TryAdd(item, 1))
            {
                return true;
            }
        }

        return false;
    }

    public static bool ContainsDuplicate1(int[] nums)
    {
        return (nums.Length > nums.Distinct().ToArray().Length);
    }
}