namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/find-smallest-letter-greater-than-target/description/
public static class FindSmallestLetterGreaterThanTarget
{
    private static char NextGreatestLetter(char[] letters, char target)
    {
        var result = letters[0];
        foreach (var item in letters)
        {
            if (item > target)
            {
                result = item;
                return result;
            }
        }

        return result;
    }

    public static void Test()
    {
        var result = NextGreatestLetter(['c', 'f', 'j'], 'd');
        Console.WriteLine(result);
    }
}