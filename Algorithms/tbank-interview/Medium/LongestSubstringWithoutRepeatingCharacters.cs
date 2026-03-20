namespace Algorithms.tbank_interview.Medium;

//https://leetcode.com/problems/longest-substring-without-repeating-characters/
public static class LongestSubstringWithoutRepeatingCharacters
{
    private static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var result = 0;
        var indexPtr = 0;
        var index = 0;
        var set = new HashSet<char>();
        while (index < s.Length)
        {
            if (!set.Add(s[index]))
            {
                result = Math.Max(result, set.Count);
                set.Clear();

                indexPtr++;
                index = indexPtr;
            }
            else
            {
                index++;
            }
        }

        result = Math.Max(result, set.Count);
        return result;
    }

    private static int LengthOfLongestSubstring_2gen(string s)
    {
        var iPtr = 0;
        var set = new HashSet<char>();
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (!set.Add(s[i]))
            {
                result = Math.Max(result, set.Count);
                set.Clear();
                iPtr++;
                i = iPtr - 1;
            }
        }


        return Math.Max(result, set.Count);
    }

    public static void Test()
    {
        var result = LengthOfLongestSubstring_2gen("abcabcbb");
        Console.WriteLine(result);
    }
}