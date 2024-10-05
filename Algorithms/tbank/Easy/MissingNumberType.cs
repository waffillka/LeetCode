namespace Algorithms.tbank.Easy;

public static class MissingNumberType
{
    public static int MissingNumber(int[] nums)
    {
        HashSet<int> countMap = new HashSet<int>(nums);

        var result = new List<int>();
        for (var i = 1; i <= nums.Length; i++)
        {
            if (!countMap.Contains(i))
            {
                return i;
            }
        }

        return 0;
    }

    public static int MissingNumber1(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        var map = new int[nums.Length + 1];

        foreach (var item in nums)
        {
            map[item] = 1;
        }

        for (var i = 0; i < map.Length; i++)
        {
            if (map[i] != 1)
                return i;
        }

        return 0;
    }
}