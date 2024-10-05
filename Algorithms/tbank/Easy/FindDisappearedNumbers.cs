namespace Algorithms.tbank.Easy;

public static class FindDisappearedNumbersType
{
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> countMap = new HashSet<int>(nums);
        
        var result = new List<int>();
        for (var i = 1; i <= nums.Length; i++)
        {
            if (!countMap.Contains(i))
            {
                result.Add(i);
            }
        }
        
        return result;
    }
}