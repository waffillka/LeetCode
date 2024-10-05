namespace Algorithms.tbank.Easy;

public static class MajorityElementType
{
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        var n = nums.Length;
        var response = 0;

        if (n == 0)
            return 0;

        foreach (var item in nums)
        {
            if (countMap.ContainsKey(item))
            {
                countMap[item]++;
            }
            else
            {
                countMap[item] = 1;
            }
            /*if (!countMap.TryAdd(item, 1))
            {
                countMap[item]++;
            }*/

            if (countMap[item] > nums.Length / 2)
            {
                response = item;
                break;
            }
        }

        return response;
    }
}