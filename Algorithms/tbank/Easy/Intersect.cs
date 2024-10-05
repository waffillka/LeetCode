namespace Algorithms.tbank.Easy;

public static class IntersectType
{
    public static int[] Intersect1(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        var result = new List<int>();

        foreach (var item in nums1)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }

        foreach (var item in nums2)
        {
            if (dict.ContainsKey(item) && dict[item] > 0)
            {
                dict[item]--;
                result.Add(item);
            }
        }

        return result.ToArray();
    }

    public static int[] Intersect2(int[] nums1, int[] nums2)
    {
        List<int> myList = new List<int>();
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        foreach (int el in nums1)
        {
            if (!myDict.TryAdd(el, 1))
            {
                myDict[el]++;
            }
        }

        foreach (int el in nums2)
        {
            if (myDict.ContainsKey(el) && myDict[el] > 0)
            {
                myDict[el]--;
                myList.Add(el);
            }
        }

        return myList.ToArray();
    }
}