namespace Algorithms.tbank_interview.Easy;

public static class FindAllNumbersDisappearedinanArray
{
    private static IList<int> FindDisappearedNumbers(int[] nums)
    {
        var result = new List<int>();
        var set = new HashSet<int>(nums);
        for (var i = 0; i < nums.Length; i++)
        {
            if (!set.Contains(i + 1))
            {
                result.Add(i + 1);
            }
        }

        return result;
    }

    private static IList<int> FindDisappearedNumbers_2gen(int[] nums)
    {
        var result = new List<int>();
        var set = new bool[nums.Length + 1];

        foreach (var item in nums)
        {
            set[item] = true;
        }


        for (var i = 1; i < set.Length; i++)
        {
            if (!set[i])
            {
                result.Add(i);
            }
        }

        return result;
    }

    public static void Test()
    {
        var result = FindDisappearedNumbers_2gen([4, 3, 2, 7, 8, 2, 3, 1]);
        Console.WriteLine(result);
    }
}