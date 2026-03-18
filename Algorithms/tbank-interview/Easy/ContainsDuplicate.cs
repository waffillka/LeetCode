namespace Algorithms.tbank_interview.Easy;

public class ContainsDuplicate
{
    private static bool ContainsDuplicate_gen(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var item in nums)
        {
            if (!set.Add(item))
            {
                return true;
            }
        }

        return false;
    }

    public static void Test()
    {
        var result = ContainsDuplicate_gen([1, 2, 3, 4, 5, 1]);
        Console.WriteLine(result);
    }
}